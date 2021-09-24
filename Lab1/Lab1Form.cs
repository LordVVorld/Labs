using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MathNet.Symbolics;

namespace Lab1
{
    public partial class lab1Form : Form
    {
        public lab1Form()
        {
            InitializeComponent();
        }

        private void LaunchButton_click(object sender, EventArgs e)
        {
            double.TryParse(lowerBorderBox.Text, out double lowerBorder);
            double.TryParse(higherBorderBox.Text, out double higherBorder);
            double.TryParse(accurancyBox.Text, out double accurancy);
            Expression formulae = Infix.ParseOrThrow(formulaeBox.Text);

            var chartSeria = ChartDraw(lowerBorder, higherBorder, accurancy, formulae);

            double minPoint = 0;

            while (higherBorder - lowerBorder >= accurancy)
            {
                double center = (higherBorder + lowerBorder) / 2;
                double left = center - accurancy;
                double right = center + accurancy;


                    if (FuncValue(left, formulae) < FuncValue(right, formulae))
                    {
                        higherBorder = center;
                    }
                    else
                    {
                        lowerBorder = center;
                    }


                minPoint = center;
            }

            GridUpload(minPoint, FuncValue(minPoint, formulae));
            chartSeria.FindByValue(minPoint, "X").Color = Color.Red;
        }

        private void ClearButton_click(object sender, EventArgs e)
        {
            var chart = formulaeChart.Series[0].Points;
            chart.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text.Remove(0);
                }
            }
        }

        private void ExitButton_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.DataVisualization.Charting.DataPointCollection ChartDraw(double start, double end, double step, Expression func)
        {
            int actualSeria = formulaeChart.Series.Count;
            formulaeChart.Series.Add("Seria" + actualSeria.ToString()).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            formulaeChart.Legends.Add("График" + actualSeria.ToString());
            var chartSeria = formulaeChart.Series[actualSeria].Points;
            while (start < end)
            {
                chartSeria.Add(start, FuncValue(start, func));
                start += step / 2;
            }
            return chartSeria;
        }

        private double FuncValue(double point, Expression func)
        {
            Dictionary<string, FloatingPoint> symbol = new Dictionary<string, FloatingPoint>()
            {
                { "x", point }
            };
            return Evaluate.Evaluate(symbol, func).RealValue;
        }

        private void GridUpload(double minPointX, double minPointY)
        {
            minPointsGrid.Rows.Add(1);
            int actualRow = minPointsGrid.Rows.Count - 2;

            minPointsGrid.Rows[actualRow].Cells[0].Value = actualRow + 1;
            minPointsGrid.Rows[actualRow].Cells[1].Value = minPointX;
            minPointsGrid.Rows[actualRow].Cells[2].Value = minPointY;
        }
    }
}

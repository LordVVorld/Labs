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
            try
            {
                double.TryParse(lowerBorderBox.Text, out double lowerBorder);
                double.TryParse(higherBorderBox.Text, out double higherBorder);
                double.TryParse(accurancyBox.Text, out double accurancy);
                Expression formulae = Infix.ParseOrThrow(formulaeBox.Text);

                int decimals = DecimalsCalc(accurancy);
                var chartSeria = ChartDraw(lowerBorder, higherBorder, accurancy, formulae);

                double minX = 0;

                if (accurancy < 0)
                {
                    throw new Exception();
                }

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
                    minX = Math.Round(center, decimals);
                }
                double minY = Math.Round(FuncValue(minX, formulae), decimals);
                GridUpload(minX, minY);
                chartSeria.Points.FindByValue(minY).BorderWidth = 8;
                chartSeria.Points.FindByValue(minY).Color = Color.Red;
                chartSeria.Points.FindByValue(minY).Label = "min";

            }
            catch
            {
                foreach (Control control in this.Controls)
                {
                    if ((control is TextBox) && control.Text.Length == 0)
                    {
                        MessageBox.Show("Нельзя оставлять поля пустыми.");
                    }
                }
                if (double.Parse(lowerBorderBox.Text) >= double.Parse(higherBorderBox.Text))
                {
                    MessageBox.Show("Значение нижней границы больше значения верхней.");
                }
                if (double.Parse(accurancyBox.Text) < 0)
                {
                    MessageBox.Show("Значение точности меньше нуля.");
                }
                if (double.Parse(higherBorderBox.Text) - double.Parse(lowerBorderBox.Text) < double.Parse(accurancyBox.Text))
                {
                    MessageBox.Show("Значение точности больше длины отрезка.");
                }
                else
                {
                    MessageBox.Show("Некорректно задана вычисляемая функция");
                }
            }
        }

        private void ClearButton_click(object sender, EventArgs e)
        {
            formulaeChart.Series.Clear();
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
            }
            minPointsGrid.Rows.Clear();
        }

        private System.Windows.Forms.DataVisualization.Charting.Series ChartDraw(double start, double end, double accurancy, Expression func)
        {
            int decimals = DecimalsCalc(accurancy);
            double step = ((end - start) / 10000 > accurancy) ? (end - start) / 10000 : accurancy;
            int actualSeria = formulaeChart.Series.Count;
            formulaeChart.Series.Add("Seria" + actualSeria.ToString()).ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            var chartSeria = formulaeChart.Series[actualSeria];
            formulaeChart.Series[actualSeria].BorderWidth = 4;
            while (start < end)
            {
                double funcValue = Math.Round(FuncValue(start, func), decimals);
                chartSeria.Points.AddXY(start, funcValue);
                start = Math.Round(start + step, decimals);
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

        private void Params_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            if (char.IsDigit(e.KeyChar) || (e.KeyChar.Equals(',') && !textBox.Text.Contains(",")) || (e.KeyChar is (char)Keys.Back) || (textBox.Text.Length.Equals(0) && e.KeyChar.Equals('-')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private int DecimalsCalc(double accurancy)
        {
            int decimals = 0;
            if (accurancy < 1)
            {
                while (accurancy < 1)
                {
                    decimals += 1;
                    accurancy *= 10;
                }
            }
            return decimals;
        }
    }
}

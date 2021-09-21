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
            int actualSeria = formulaeChart.Series.Count;
            formulaeChart.Series.Add("Seria" + actualSeria.ToString());

            var chartSeria = formulaeChart.Series[actualSeria].Points;
            SortedDictionary<double, double> points = new SortedDictionary<double, double>();

            double.TryParse(lowerBorderBox.Text, out double lowerBorder);
            double.TryParse(higherBorderBox.Text, out double higherBorder);
            double.TryParse(accurancyBox.Text, out double accurancy);
            Expression formulae = Infix.ParseOrThrow(formulaeBox.Text);
            formulaeChart.Legends.Add("График" + actualSeria.ToString());

            Expression derivative = Calculus.Differentiate(Expression.Symbol("x"), formulae);
            Dictionary<string, FloatingPoint> symbol = new Dictionary<string, FloatingPoint>()
            {
                { "x", lowerBorder }
            };

            points.Add(lowerBorder, Evaluate.Evaluate(symbol, formulae).RealValue);

            double lowerBorderDerivative = Evaluate.Evaluate(symbol, derivative).RealValue;
            double center = (higherBorder + lowerBorder) / 2;

            while (higherBorder - lowerBorder >= accurancy)
            {
                center = (higherBorder + lowerBorder) / 2;
                symbol["x"] = center;
                points.Add(center, Evaluate.Evaluate(symbol, formulae).RealValue);
                double centerDerivative = Evaluate.Evaluate(symbol, derivative).RealValue;

                if (lowerBorderDerivative * centerDerivative <= 0)
                {
                    higherBorder = center;
                }
                else
                {
                    lowerBorder = center;
                }
            }
            minPointsGrid.Rows.Add(1);
            int actualRow = minPointsGrid.Rows.Count - 2;
            minPointsGrid.Rows[actualRow].Cells[0].Value = actualRow;
            minPointsGrid.Rows[actualRow].Cells[1].Value = center;
            minPointsGrid.Rows[actualRow].Cells[2].Value = points[center];
            foreach (var point in points)
            {
                chartSeria.AddXY(point.Key, point.Value);
            }
            chartSeria.FindByValue(points[center]).Color = Color.Red;
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

    }
}

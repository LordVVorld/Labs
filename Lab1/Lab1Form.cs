using System;
using System.Collections.Generic;
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

        private void launchButton_click(object sender, EventArgs e)
        {
            var chart = formulaeChart.Series[0].Points;
            chart.Clear();

            double.TryParse(lowerBorderBox.Text, out double lowerBorder);
            double.TryParse(higherBorderBox.Text, out double higherBorder);
            double.TryParse(accurancyBox.Text, out double accurancy);
            Expression formulae = Infix.ParseOrThrow(formulaeBox.Text);

            Expression derivative = Calculus.Differentiate(Expression.Symbol("x"), formulae);
            Dictionary<string, FloatingPoint> symbol = new Dictionary<string, FloatingPoint>()
            {
                { "x", lowerBorder }
            };

            chart.AddXY(lowerBorder, Evaluate.Evaluate(symbol, formulae).RealValue);
            double lowerBorderDerivative = Evaluate.Evaluate(symbol, derivative).RealValue;

            while (higherBorder - lowerBorder >= accurancy)
            {
                double center = (higherBorder + lowerBorder) / 2;
                symbol["x"] = center;
                chart.AddXY(center, Evaluate.Evaluate(symbol, formulae).RealValue);
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
            minPointBox.Text = Evaluate.Evaluate(symbol, formulae).RealValue.ToString();
        }
    }
}

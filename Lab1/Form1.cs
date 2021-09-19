using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double.TryParse(aParametrBox.Text, out double aParam);
            double.TryParse(bParametrBox.Text, out double bParam);
            double.TryParse(eParametrBox.Text, out double eParam);

            double center = (aParam + bParam) / 2;


            Expression formulae = Infix.ParseOrThrow(formulaeBox.Text);
            minPointBox.Text = Infix.Format(Expression.Root(Expression.Symbol("2"), formulae));
            Expression derivative = Calculus.Differentiate(Expression.Symbol("x"), formulae);
            
        }
    }
}

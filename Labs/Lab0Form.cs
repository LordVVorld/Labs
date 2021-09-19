using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs
{
    public partial class Lab0 : Form
    {
        public Lab0()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void task1LaunchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Data data = new Data
                {
                    Mass = Convert.ToDouble(massBox.Text),
                    Density = Convert.ToDouble(densityBox.Text),
                    Radius = Convert.ToDouble(radiusBox.Text)
                };
                thicknessBox.Text = ((Math.PI * Math.Pow(data.Radius, 2) * data.Density * 1000) / data.Mass).ToString("0.000");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Пустые поля запрещены.");
            }
            catch (ExtremelyHighValueExeption)
            {
                MessageBox.Show("Значение превышает допустимое.");
            }
            catch (ExtremelyLowValueExeption)
            {
                MessageBox.Show("Значение ниже минимально допустимого.");
            }
        }

        private void task2GenButton_Click(object sender, EventArgs e)
        {
            Random genRand = new Random();
            Random firstNameRand = new Random();
            Random lastNameRand = new Random();
            Random heightRand = new Random();
            List<Person> personList = new List<Person>();
            for (int personsNumber = 10; personsNumber > 0; --personsNumber)
            {
                dataGrid.Rows.Add();
                int actualRow = dataGrid.Rows.Count - 2;
                Person person = new Person(genRand.Next(2), firstNameRand.Next(Person.femaleFirstNameList.Count), lastNameRand.Next(Person.lastNameList.Count), heightRand.NextDouble());
                personList.Add(person);
                dataGrid.Rows[actualRow].Cells[0].Value = actualRow;
                dataGrid.Rows[actualRow].Cells[1].Value = person.FirstName;
                dataGrid.Rows[actualRow].Cells[2].Value = person.LastName;
                dataGrid.Rows[actualRow].Cells[3].Value = person.Gender;
                dataGrid.Rows[actualRow].Cells[4].Value = person.Height;
            }
            
            
        }

        private void task2LaunchButton_Click(object sender, EventArgs e)
        {
            double averageMensHeight = 0;
            double averageWomansHeight = 0;
            byte manCount = 0;
            double maxMensHeight = 0;
            double maxWomansHeight = 0;
            byte womanCount = 0;
            int rowCount = dataGrid.Rows.Count;
            for (int id = 0; id < rowCount; ++id)
            {
                double height = Convert.ToDouble(dataGrid.Rows[id].Cells[4].Value);
                if (Convert.ToChar(dataGrid.Rows[id].Cells[3].Value) == 'M')
                {
                    maxMensHeight = (height > maxMensHeight) ? height : maxMensHeight;
                    averageMensHeight += height;
                    manCount += 1;
                }
                else
                {
                    maxWomansHeight = (height > maxWomansHeight) ? height : maxWomansHeight;
                    averageWomansHeight += height;
                    womanCount += 1;
                }
            }
            averageMensHeight = Math.Round(averageMensHeight / manCount, 2);
            averageWomansHeight = Math.Round(averageWomansHeight / womanCount, 2);
            menMaxHeightBox.Text = maxMensHeight.ToString();
            womanMaxHeightBox.Text = maxWomansHeight.ToString();
            menAverageHeightBox.Text = averageMensHeight.ToString();
            womanAverageHeightBox.Text = averageWomansHeight.ToString();
        }

        
        private void dataBoxex_KeyPress(object sender, KeyPressEventArgs e)
        {
            var selectedBox = sender as TextBox;
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && !selectedBox.Text.Contains(',')) || e.KeyChar == Convert.ToChar(Keys.Back))
            {
                return;
            }
            else
            {
                if (e.KeyChar == ',')
                {
                    MessageBox.Show("Допускается лишь один разделитель.");
                }
                else
                {
                    MessageBox.Show("Недопустимый символ.");
                }
                e.Handled = true;
            }
        }

        private void textBoxes_MouseEnter(object sender, EventArgs e)
        {
            var selectedBox = sender as TextBox;
            ToolTip help = new ToolTip();
            help.SetToolTip(selectedBox, "0 - 10000");
        }


    }
}

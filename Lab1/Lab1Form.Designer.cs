
namespace Lab1
{
    partial class lab1Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lowerBorderBox = new System.Windows.Forms.TextBox();
            this.higherBorderBox = new System.Windows.Forms.TextBox();
            this.accurancyBox = new System.Windows.Forms.TextBox();
            this.formulaeBox = new System.Windows.Forms.TextBox();
            this.lowerBorderLabel = new System.Windows.Forms.Label();
            this.higherBorderLabel = new System.Windows.Forms.Label();
            this.accurancyLabel = new System.Windows.Forms.Label();
            this.formulaeLabel = new System.Windows.Forms.Label();
            this.minPointLabel = new System.Windows.Forms.Label();
            this.minPointBox = new System.Windows.Forms.TextBox();
            this.lab0Menu = new System.Windows.Forms.MenuStrip();
            this.launchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.ToolStripMenuItem();
            this.formulaeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lab0Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lowerBorderBox
            // 
            this.lowerBorderBox.Location = new System.Drawing.Point(12, 27);
            this.lowerBorderBox.Name = "lowerBorderBox";
            this.lowerBorderBox.Size = new System.Drawing.Size(100, 20);
            this.lowerBorderBox.TabIndex = 0;
            // 
            // higherBorderBox
            // 
            this.higherBorderBox.Location = new System.Drawing.Point(12, 53);
            this.higherBorderBox.Name = "higherBorderBox";
            this.higherBorderBox.Size = new System.Drawing.Size(100, 20);
            this.higherBorderBox.TabIndex = 1;
            // 
            // accurancyBox
            // 
            this.accurancyBox.Location = new System.Drawing.Point(12, 79);
            this.accurancyBox.Name = "accurancyBox";
            this.accurancyBox.Size = new System.Drawing.Size(100, 20);
            this.accurancyBox.TabIndex = 2;
            // 
            // formulaeBox
            // 
            this.formulaeBox.Location = new System.Drawing.Point(12, 105);
            this.formulaeBox.Name = "formulaeBox";
            this.formulaeBox.Size = new System.Drawing.Size(100, 20);
            this.formulaeBox.TabIndex = 3;
            // 
            // lowerBorderLabel
            // 
            this.lowerBorderLabel.AutoSize = true;
            this.lowerBorderLabel.Location = new System.Drawing.Point(118, 30);
            this.lowerBorderLabel.Name = "lowerBorderLabel";
            this.lowerBorderLabel.Size = new System.Drawing.Size(91, 13);
            this.lowerBorderLabel.TabIndex = 4;
            this.lowerBorderLabel.Text = "Нижняя граница";
            // 
            // higherBorderLabel
            // 
            this.higherBorderLabel.AutoSize = true;
            this.higherBorderLabel.Location = new System.Drawing.Point(118, 56);
            this.higherBorderLabel.Name = "higherBorderLabel";
            this.higherBorderLabel.Size = new System.Drawing.Size(93, 13);
            this.higherBorderLabel.TabIndex = 5;
            this.higherBorderLabel.Text = "Верхняя граница";
            // 
            // accurancyLabel
            // 
            this.accurancyLabel.AutoSize = true;
            this.accurancyLabel.Location = new System.Drawing.Point(118, 82);
            this.accurancyLabel.Name = "accurancyLabel";
            this.accurancyLabel.Size = new System.Drawing.Size(54, 13);
            this.accurancyLabel.TabIndex = 6;
            this.accurancyLabel.Text = "Точность";
            // 
            // formulaeLabel
            // 
            this.formulaeLabel.AutoSize = true;
            this.formulaeLabel.Location = new System.Drawing.Point(118, 108);
            this.formulaeLabel.Name = "formulaeLabel";
            this.formulaeLabel.Size = new System.Drawing.Size(53, 13);
            this.formulaeLabel.TabIndex = 7;
            this.formulaeLabel.Text = "Функция";
            // 
            // minPointLabel
            // 
            this.minPointLabel.AutoSize = true;
            this.minPointLabel.Location = new System.Drawing.Point(118, 209);
            this.minPointLabel.Name = "minPointLabel";
            this.minPointLabel.Size = new System.Drawing.Size(93, 13);
            this.minPointLabel.TabIndex = 10;
            this.minPointLabel.Text = "Точка минимума";
            // 
            // minPointBox
            // 
            this.minPointBox.Enabled = false;
            this.minPointBox.Location = new System.Drawing.Point(12, 206);
            this.minPointBox.Name = "minPointBox";
            this.minPointBox.Size = new System.Drawing.Size(100, 20);
            this.minPointBox.TabIndex = 9;
            // 
            // lab0Menu
            // 
            this.lab0Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launchButton,
            this.clearButton});
            this.lab0Menu.Location = new System.Drawing.Point(0, 0);
            this.lab0Menu.Name = "lab0Menu";
            this.lab0Menu.Size = new System.Drawing.Size(800, 24);
            this.lab0Menu.TabIndex = 11;
            // 
            // launchButton
            // 
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(57, 20);
            this.launchButton.Text = "Запуск";
            this.launchButton.Click += new System.EventHandler(this.launchButton_click);
            // 
            // clearButton
            // 
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(65, 20);
            this.clearButton.Text = "Очистка";
            // 
            // formulaeChart
            // 
            chartArea1.Name = "ChartArea1";
            this.formulaeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.formulaeChart.Legends.Add(legend1);
            this.formulaeChart.Location = new System.Drawing.Point(215, 27);
            this.formulaeChart.Name = "formulaeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.formulaeChart.Series.Add(series1);
            this.formulaeChart.Size = new System.Drawing.Size(573, 300);
            this.formulaeChart.TabIndex = 12;
            this.formulaeChart.Text = "chart1";
            // 
            // lab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.formulaeChart);
            this.Controls.Add(this.minPointLabel);
            this.Controls.Add(this.minPointBox);
            this.Controls.Add(this.formulaeLabel);
            this.Controls.Add(this.accurancyLabel);
            this.Controls.Add(this.higherBorderLabel);
            this.Controls.Add(this.lowerBorderLabel);
            this.Controls.Add(this.formulaeBox);
            this.Controls.Add(this.accurancyBox);
            this.Controls.Add(this.higherBorderBox);
            this.Controls.Add(this.lowerBorderBox);
            this.Controls.Add(this.lab0Menu);
            this.MainMenuStrip = this.lab0Menu;
            this.Name = "lab1Form";
            this.Text = "Lab1";
            this.lab0Menu.ResumeLayout(false);
            this.lab0Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lowerBorderBox;
        private System.Windows.Forms.TextBox higherBorderBox;
        private System.Windows.Forms.TextBox accurancyBox;
        private System.Windows.Forms.TextBox formulaeBox;
        private System.Windows.Forms.Label lowerBorderLabel;
        private System.Windows.Forms.Label higherBorderLabel;
        private System.Windows.Forms.Label accurancyLabel;
        private System.Windows.Forms.Label formulaeLabel;
        private System.Windows.Forms.Label minPointLabel;
        private System.Windows.Forms.TextBox minPointBox;
        private System.Windows.Forms.MenuStrip lab0Menu;
        private System.Windows.Forms.ToolStripMenuItem launchButton;
        private System.Windows.Forms.ToolStripMenuItem clearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart formulaeChart;
    }
}


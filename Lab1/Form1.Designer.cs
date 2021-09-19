
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
            this.aParametrBox = new System.Windows.Forms.TextBox();
            this.bParametrBox = new System.Windows.Forms.TextBox();
            this.eParametrBox = new System.Windows.Forms.TextBox();
            this.formulaeBox = new System.Windows.Forms.TextBox();
            this.aParametrBoxLabel = new System.Windows.Forms.Label();
            this.bParametrBoxLabel = new System.Windows.Forms.Label();
            this.eParametrBoxLabel = new System.Windows.Forms.Label();
            this.formulaeBoxLabel = new System.Windows.Forms.Label();
            this.formulaeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.minPointBoxLabel = new System.Windows.Forms.Label();
            this.minPointBox = new System.Windows.Forms.TextBox();
            this.lab0Menu = new System.Windows.Forms.MenuStrip();
            this.launchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).BeginInit();
            this.lab0Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // aParametrBox
            // 
            this.aParametrBox.Location = new System.Drawing.Point(12, 27);
            this.aParametrBox.Name = "aParametrBox";
            this.aParametrBox.Size = new System.Drawing.Size(100, 20);
            this.aParametrBox.TabIndex = 0;
            // 
            // bParametrBox
            // 
            this.bParametrBox.Location = new System.Drawing.Point(12, 53);
            this.bParametrBox.Name = "bParametrBox";
            this.bParametrBox.Size = new System.Drawing.Size(100, 20);
            this.bParametrBox.TabIndex = 1;
            // 
            // eParametrBox
            // 
            this.eParametrBox.Location = new System.Drawing.Point(12, 79);
            this.eParametrBox.Name = "eParametrBox";
            this.eParametrBox.Size = new System.Drawing.Size(100, 20);
            this.eParametrBox.TabIndex = 2;
            // 
            // formulaeBox
            // 
            this.formulaeBox.Location = new System.Drawing.Point(12, 105);
            this.formulaeBox.Name = "formulaeBox";
            this.formulaeBox.Size = new System.Drawing.Size(100, 20);
            this.formulaeBox.TabIndex = 3;
            // 
            // aParametrBoxLabel
            // 
            this.aParametrBoxLabel.AutoSize = true;
            this.aParametrBoxLabel.Location = new System.Drawing.Point(118, 30);
            this.aParametrBoxLabel.Name = "aParametrBoxLabel";
            this.aParametrBoxLabel.Size = new System.Drawing.Size(67, 13);
            this.aParametrBoxLabel.TabIndex = 4;
            this.aParametrBoxLabel.Text = "Параметр а";
            // 
            // bParametrBoxLabel
            // 
            this.bParametrBoxLabel.AutoSize = true;
            this.bParametrBoxLabel.Location = new System.Drawing.Point(118, 56);
            this.bParametrBoxLabel.Name = "bParametrBoxLabel";
            this.bParametrBoxLabel.Size = new System.Drawing.Size(67, 13);
            this.bParametrBoxLabel.TabIndex = 5;
            this.bParametrBoxLabel.Text = "Параметр b";
            // 
            // eParametrBoxLabel
            // 
            this.eParametrBoxLabel.AutoSize = true;
            this.eParametrBoxLabel.Location = new System.Drawing.Point(118, 82);
            this.eParametrBoxLabel.Name = "eParametrBoxLabel";
            this.eParametrBoxLabel.Size = new System.Drawing.Size(67, 13);
            this.eParametrBoxLabel.TabIndex = 6;
            this.eParametrBoxLabel.Text = "Параметр е";
            // 
            // formulaeBoxLabel
            // 
            this.formulaeBoxLabel.AutoSize = true;
            this.formulaeBoxLabel.Location = new System.Drawing.Point(118, 108);
            this.formulaeBoxLabel.Name = "formulaeBoxLabel";
            this.formulaeBoxLabel.Size = new System.Drawing.Size(93, 13);
            this.formulaeBoxLabel.TabIndex = 7;
            this.formulaeBoxLabel.Text = "Строка формулы";
            // 
            // formulaeChart
            // 
            this.formulaeChart.Location = new System.Drawing.Point(217, 27);
            this.formulaeChart.Name = "formulaeChart";
            this.formulaeChart.Size = new System.Drawing.Size(300, 300);
            this.formulaeChart.TabIndex = 8;
            this.formulaeChart.Text = "chart1";
            // 
            // minPointBoxLabel
            // 
            this.minPointBoxLabel.AutoSize = true;
            this.minPointBoxLabel.Location = new System.Drawing.Point(118, 209);
            this.minPointBoxLabel.Name = "minPointBoxLabel";
            this.minPointBoxLabel.Size = new System.Drawing.Size(93, 13);
            this.minPointBoxLabel.TabIndex = 10;
            this.minPointBoxLabel.Text = "Точка минимума";
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
            // lab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minPointBoxLabel);
            this.Controls.Add(this.minPointBox);
            this.Controls.Add(this.formulaeChart);
            this.Controls.Add(this.formulaeBoxLabel);
            this.Controls.Add(this.eParametrBoxLabel);
            this.Controls.Add(this.bParametrBoxLabel);
            this.Controls.Add(this.aParametrBoxLabel);
            this.Controls.Add(this.formulaeBox);
            this.Controls.Add(this.eParametrBox);
            this.Controls.Add(this.bParametrBox);
            this.Controls.Add(this.aParametrBox);
            this.Controls.Add(this.lab0Menu);
            this.MainMenuStrip = this.lab0Menu;
            this.Name = "lab1Form";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.formulaeChart)).EndInit();
            this.lab0Menu.ResumeLayout(false);
            this.lab0Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aParametrBox;
        private System.Windows.Forms.TextBox bParametrBox;
        private System.Windows.Forms.TextBox eParametrBox;
        private System.Windows.Forms.TextBox formulaeBox;
        private System.Windows.Forms.Label aParametrBoxLabel;
        private System.Windows.Forms.Label bParametrBoxLabel;
        private System.Windows.Forms.Label eParametrBoxLabel;
        private System.Windows.Forms.Label formulaeBoxLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart formulaeChart;
        private System.Windows.Forms.Label minPointBoxLabel;
        private System.Windows.Forms.TextBox minPointBox;
        private System.Windows.Forms.MenuStrip lab0Menu;
        private System.Windows.Forms.ToolStripMenuItem launchButton;
        private System.Windows.Forms.ToolStripMenuItem clearButton;
    }
}


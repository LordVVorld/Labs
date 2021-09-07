namespace Labs
{
    partial class Form1
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
            this.densityBox = new System.Windows.Forms.TextBox();
            this.densityLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.task1Page = new System.Windows.Forms.TabPage();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.thicknessBox = new System.Windows.Forms.TextBox();
            this.massBox = new System.Windows.Forms.TextBox();
            this.massLabel = new System.Windows.Forms.Label();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.task2Page = new System.Windows.Forms.TabPage();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menAverageHeightLabel = new System.Windows.Forms.Label();
            this.menAverageHeightBox = new System.Windows.Forms.TextBox();
            this.firstNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.womanAverageHeightLabel = new System.Windows.Forms.Label();
            this.womanAverageHeightBox = new System.Windows.Forms.TextBox();
            this.overallAverageHeightLabel = new System.Windows.Forms.Label();
            this.overallAverageHeightBox = new System.Windows.Forms.TextBox();
            this.menMaxHeightLabel = new System.Windows.Forms.Label();
            this.womanMaxHeightBox = new System.Windows.Forms.TextBox();
            this.womanMaxHeightLabel = new System.Windows.Forms.Label();
            this.menMaxHeightBox = new System.Windows.Forms.TextBox();
            this.task2LaunchButton = new System.Windows.Forms.Button();
            this.task1LaunchButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.task1Page.SuspendLayout();
            this.task2Page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // densityBox
            // 
            this.densityBox.Location = new System.Drawing.Point(15, 30);
            this.densityBox.Name = "densityBox";
            this.densityBox.Size = new System.Drawing.Size(116, 20);
            this.densityBox.TabIndex = 0;
            // 
            // densityLabel
            // 
            this.densityLabel.AutoSize = true;
            this.densityLabel.Location = new System.Drawing.Point(12, 14);
            this.densityLabel.Name = "densityLabel";
            this.densityLabel.Size = new System.Drawing.Size(119, 13);
            this.densityLabel.TabIndex = 1;
            this.densityLabel.Text = "Плотность материала";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.task1Page);
            this.tabControl1.Controls.Add(this.task2Page);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 435);
            this.tabControl1.TabIndex = 2;
            // 
            // task1Page
            // 
            this.task1Page.Controls.Add(this.resultLabel);
            this.task1Page.Controls.Add(this.task1LaunchButton);
            this.task1Page.Controls.Add(this.thicknessLabel);
            this.task1Page.Controls.Add(this.thicknessBox);
            this.task1Page.Controls.Add(this.massBox);
            this.task1Page.Controls.Add(this.massLabel);
            this.task1Page.Controls.Add(this.radiusBox);
            this.task1Page.Controls.Add(this.radiusLabel);
            this.task1Page.Controls.Add(this.densityBox);
            this.task1Page.Controls.Add(this.densityLabel);
            this.task1Page.Location = new System.Drawing.Point(4, 22);
            this.task1Page.Name = "task1Page";
            this.task1Page.Padding = new System.Windows.Forms.Padding(3);
            this.task1Page.Size = new System.Drawing.Size(588, 409);
            this.task1Page.TabIndex = 0;
            this.task1Page.Text = "Задание 1";
            this.task1Page.UseVisualStyleBackColor = true;
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.AutoSize = true;
            this.thicknessLabel.Location = new System.Drawing.Point(393, 14);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(86, 13);
            this.thicknessLabel.TabIndex = 7;
            this.thicknessLabel.Text = "Толщина диска";
            // 
            // thicknessBox
            // 
            this.thicknessBox.Enabled = false;
            this.thicknessBox.Location = new System.Drawing.Point(381, 30);
            this.thicknessBox.Name = "thicknessBox";
            this.thicknessBox.Size = new System.Drawing.Size(116, 20);
            this.thicknessBox.TabIndex = 6;
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(259, 30);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(116, 20);
            this.massBox.TabIndex = 4;
            // 
            // massLabel
            // 
            this.massLabel.AutoSize = true;
            this.massLabel.Location = new System.Drawing.Point(280, 14);
            this.massLabel.Name = "massLabel";
            this.massLabel.Size = new System.Drawing.Size(73, 13);
            this.massLabel.TabIndex = 5;
            this.massLabel.Text = "Масса диска";
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(137, 30);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(116, 20);
            this.radiusBox.TabIndex = 2;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(155, 14);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(76, 13);
            this.radiusLabel.TabIndex = 3;
            this.radiusLabel.Text = "Радиус диска";
            // 
            // task2Page
            // 
            this.task2Page.Controls.Add(this.task2LaunchButton);
            this.task2Page.Controls.Add(this.womanMaxHeightLabel);
            this.task2Page.Controls.Add(this.menMaxHeightBox);
            this.task2Page.Controls.Add(this.menMaxHeightLabel);
            this.task2Page.Controls.Add(this.womanMaxHeightBox);
            this.task2Page.Controls.Add(this.overallAverageHeightLabel);
            this.task2Page.Controls.Add(this.overallAverageHeightBox);
            this.task2Page.Controls.Add(this.womanAverageHeightLabel);
            this.task2Page.Controls.Add(this.womanAverageHeightBox);
            this.task2Page.Controls.Add(this.menAverageHeightLabel);
            this.task2Page.Controls.Add(this.menAverageHeightBox);
            this.task2Page.Controls.Add(this.dataGrid);
            this.task2Page.Location = new System.Drawing.Point(4, 22);
            this.task2Page.Name = "task2Page";
            this.task2Page.Padding = new System.Windows.Forms.Padding(3);
            this.task2Page.Size = new System.Drawing.Size(588, 409);
            this.task2Page.TabIndex = 1;
            this.task2Page.Text = "Задание 2";
            this.task2Page.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameCol,
            this.lastNameCol,
            this.genderCol,
            this.heightCol});
            this.dataGrid.Location = new System.Drawing.Point(6, 6);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(454, 397);
            this.dataGrid.TabIndex = 0;
            // 
            // menAverageHeightLabel
            // 
            this.menAverageHeightLabel.AutoSize = true;
            this.menAverageHeightLabel.Location = new System.Drawing.Point(475, 6);
            this.menAverageHeightLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.menAverageHeightLabel.Name = "menAverageHeightLabel";
            this.menAverageHeightLabel.Size = new System.Drawing.Size(98, 26);
            this.menAverageHeightLabel.TabIndex = 9;
            this.menAverageHeightLabel.Text = "Средний мужской рост";
            this.menAverageHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menAverageHeightBox
            // 
            this.menAverageHeightBox.Enabled = false;
            this.menAverageHeightBox.Location = new System.Drawing.Point(464, 35);
            this.menAverageHeightBox.Name = "menAverageHeightBox";
            this.menAverageHeightBox.Size = new System.Drawing.Size(121, 20);
            this.menAverageHeightBox.TabIndex = 8;
            // 
            // firstNameCol
            // 
            this.firstNameCol.HeaderText = "Имя";
            this.firstNameCol.Name = "firstNameCol";
            // 
            // lastNameCol
            // 
            this.lastNameCol.HeaderText = "Фамилия";
            this.lastNameCol.Name = "lastNameCol";
            // 
            // genderCol
            // 
            this.genderCol.HeaderText = "Пол";
            this.genderCol.Name = "genderCol";
            // 
            // heightCol
            // 
            this.heightCol.HeaderText = "Рост";
            this.heightCol.Name = "heightCol";
            // 
            // womanAverageHeightLabel
            // 
            this.womanAverageHeightLabel.AutoSize = true;
            this.womanAverageHeightLabel.Location = new System.Drawing.Point(476, 58);
            this.womanAverageHeightLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.womanAverageHeightLabel.Name = "womanAverageHeightLabel";
            this.womanAverageHeightLabel.Size = new System.Drawing.Size(97, 26);
            this.womanAverageHeightLabel.TabIndex = 11;
            this.womanAverageHeightLabel.Text = "Средний женский рост";
            this.womanAverageHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // womanAverageHeightBox
            // 
            this.womanAverageHeightBox.Enabled = false;
            this.womanAverageHeightBox.Location = new System.Drawing.Point(464, 87);
            this.womanAverageHeightBox.Name = "womanAverageHeightBox";
            this.womanAverageHeightBox.Size = new System.Drawing.Size(121, 20);
            this.womanAverageHeightBox.TabIndex = 10;
            // 
            // overallAverageHeightLabel
            // 
            this.overallAverageHeightLabel.AutoSize = true;
            this.overallAverageHeightLabel.Location = new System.Drawing.Point(476, 110);
            this.overallAverageHeightLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.overallAverageHeightLabel.Name = "overallAverageHeightLabel";
            this.overallAverageHeightLabel.Size = new System.Drawing.Size(87, 26);
            this.overallAverageHeightLabel.TabIndex = 13;
            this.overallAverageHeightLabel.Text = "Общий средний рост";
            this.overallAverageHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // overallAverageHeightBox
            // 
            this.overallAverageHeightBox.Enabled = false;
            this.overallAverageHeightBox.Location = new System.Drawing.Point(464, 139);
            this.overallAverageHeightBox.Name = "overallAverageHeightBox";
            this.overallAverageHeightBox.Size = new System.Drawing.Size(119, 20);
            this.overallAverageHeightBox.TabIndex = 12;
            // 
            // menMaxHeightLabel
            // 
            this.menMaxHeightLabel.AutoSize = true;
            this.menMaxHeightLabel.Location = new System.Drawing.Point(485, 162);
            this.menMaxHeightLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.menMaxHeightLabel.Name = "menMaxHeightLabel";
            this.menMaxHeightLabel.Size = new System.Drawing.Size(78, 26);
            this.menMaxHeightLabel.TabIndex = 15;
            this.menMaxHeightLabel.Text = "Наибольший мужской рост";
            this.menMaxHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // womanMaxHeightBox
            // 
            this.womanMaxHeightBox.Enabled = false;
            this.womanMaxHeightBox.Location = new System.Drawing.Point(464, 245);
            this.womanMaxHeightBox.Name = "womanMaxHeightBox";
            this.womanMaxHeightBox.Size = new System.Drawing.Size(119, 20);
            this.womanMaxHeightBox.TabIndex = 14;
            // 
            // womanMaxHeightLabel
            // 
            this.womanMaxHeightLabel.AutoSize = true;
            this.womanMaxHeightLabel.Location = new System.Drawing.Point(485, 216);
            this.womanMaxHeightLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.womanMaxHeightLabel.Name = "womanMaxHeightLabel";
            this.womanMaxHeightLabel.Size = new System.Drawing.Size(77, 26);
            this.womanMaxHeightLabel.TabIndex = 17;
            this.womanMaxHeightLabel.Text = "Наибольший женский рост";
            this.womanMaxHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menMaxHeightBox
            // 
            this.menMaxHeightBox.Enabled = false;
            this.menMaxHeightBox.Location = new System.Drawing.Point(464, 191);
            this.menMaxHeightBox.Name = "menMaxHeightBox";
            this.menMaxHeightBox.Size = new System.Drawing.Size(119, 20);
            this.menMaxHeightBox.TabIndex = 16;
            // 
            // task2LaunchButton
            // 
            this.task2LaunchButton.Location = new System.Drawing.Point(467, 368);
            this.task2LaunchButton.Name = "task2LaunchButton";
            this.task2LaunchButton.Size = new System.Drawing.Size(116, 35);
            this.task2LaunchButton.TabIndex = 18;
            this.task2LaunchButton.Text = "Запуск";
            this.task2LaunchButton.UseVisualStyleBackColor = true;
            // 
            // task1LaunchButton
            // 
            this.task1LaunchButton.Location = new System.Drawing.Point(15, 56);
            this.task1LaunchButton.Name = "task1LaunchButton";
            this.task1LaunchButton.Size = new System.Drawing.Size(116, 35);
            this.task1LaunchButton.TabIndex = 19;
            this.task1LaunchButton.Text = "Запуск";
            this.task1LaunchButton.UseVisualStyleBackColor = true;
            this.task1LaunchButton.Click += new System.EventHandler(this.task1Launch_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(137, 67);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(59, 13);
            this.resultLabel.TabIndex = 20;
            this.resultLabel.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лаб0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.task1Page.ResumeLayout(false);
            this.task1Page.PerformLayout();
            this.task2Page.ResumeLayout(false);
            this.task2Page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox densityBox;
        private System.Windows.Forms.Label densityLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage task1Page;
        private System.Windows.Forms.TextBox thicknessBox;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.Label massLabel;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TabPage task2Page;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.Label menMaxHeightLabel;
        private System.Windows.Forms.TextBox womanMaxHeightBox;
        private System.Windows.Forms.Label overallAverageHeightLabel;
        private System.Windows.Forms.TextBox overallAverageHeightBox;
        private System.Windows.Forms.Label womanAverageHeightLabel;
        private System.Windows.Forms.TextBox womanAverageHeightBox;
        private System.Windows.Forms.Label menAverageHeightLabel;
        private System.Windows.Forms.TextBox menAverageHeightBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightCol;
        private System.Windows.Forms.Button task2LaunchButton;
        private System.Windows.Forms.Label womanMaxHeightLabel;
        private System.Windows.Forms.TextBox menMaxHeightBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button task1LaunchButton;
    }
}


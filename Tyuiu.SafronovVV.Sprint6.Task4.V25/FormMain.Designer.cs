
namespace Tyuiu.SafronovVV.Sprint6.Task4.V25
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStartIn_SVV = new System.Windows.Forms.TextBox();
            this.textBoxStopIn_SVV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDone_SVV_Click = new System.Windows.Forms.Button();
            this.buttonSave_SVV_Click = new System.Windows.Forms.Button();
            this.buttonHelp_SVV_Click = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOutArr_SVV = new System.Windows.Forms.TextBox();
            this.chartFunction_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(435, 52);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Протабулировать функцию f(x) на заданном диапазоне [-5; 5]\r\nРезультат вывести в t" +
    "extBox, построить график функции и сохранить в файл OutPutFile Task.txt по нажат" +
    "ию кнопки.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxStopIn_SVV);
            this.groupBox2.Controls.Add(this.textBoxStartIn_SVV);
            this.groupBox2.Location = new System.Drawing.Point(465, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных";
            // 
            // textBoxStartIn_SVV
            // 
            this.textBoxStartIn_SVV.Location = new System.Drawing.Point(6, 39);
            this.textBoxStartIn_SVV.Name = "textBoxStartIn_SVV";
            this.textBoxStartIn_SVV.Size = new System.Drawing.Size(120, 20);
            this.textBoxStartIn_SVV.TabIndex = 2;
            // 
            // textBoxStopIn_SVV
            // 
            this.textBoxStopIn_SVV.Location = new System.Drawing.Point(132, 39);
            this.textBoxStopIn_SVV.Name = "textBoxStopIn_SVV";
            this.textBoxStopIn_SVV.Size = new System.Drawing.Size(120, 20);
            this.textBoxStopIn_SVV.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Старт шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конец шага:";
            // 
            // buttonDone_SVV_Click
            // 
            this.buttonDone_SVV_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_SVV_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonDone_SVV_Click.Location = new System.Drawing.Point(730, 18);
            this.buttonDone_SVV_Click.Name = "buttonDone_SVV_Click";
            this.buttonDone_SVV_Click.Size = new System.Drawing.Size(122, 65);
            this.buttonDone_SVV_Click.TabIndex = 2;
            this.buttonDone_SVV_Click.Text = "Выполнить";
            this.buttonDone_SVV_Click.UseVisualStyleBackColor = false;
            this.buttonDone_SVV_Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave_SVV_Click
            // 
            this.buttonSave_SVV_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSave_SVV_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSave_SVV_Click.Location = new System.Drawing.Point(858, 18);
            this.buttonSave_SVV_Click.Name = "buttonSave_SVV_Click";
            this.buttonSave_SVV_Click.Size = new System.Drawing.Size(122, 65);
            this.buttonSave_SVV_Click.TabIndex = 3;
            this.buttonSave_SVV_Click.Text = "Сохранить";
            this.buttonSave_SVV_Click.UseVisualStyleBackColor = false;
            this.buttonSave_SVV_Click.Click += new System.EventHandler(this.buttonSave_SVV_Click_Click);
            // 
            // buttonHelp_SVV_Click
            // 
            this.buttonHelp_SVV_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp_SVV_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonHelp_SVV_Click.Location = new System.Drawing.Point(986, 18);
            this.buttonHelp_SVV_Click.Name = "buttonHelp_SVV_Click";
            this.buttonHelp_SVV_Click.Size = new System.Drawing.Size(122, 65);
            this.buttonHelp_SVV_Click.TabIndex = 4;
            this.buttonHelp_SVV_Click.Text = "Справка";
            this.buttonHelp_SVV_Click.UseVisualStyleBackColor = false;
            this.buttonHelp_SVV_Click.Click += new System.EventHandler(this.buttonHelp_SVV_Click_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOutArr_SVV);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 522);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод";
            // 
            // textBoxOutArr_SVV
            // 
            this.textBoxOutArr_SVV.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutArr_SVV.Multiline = true;
            this.textBoxOutArr_SVV.Name = "textBoxOutArr_SVV";
            this.textBoxOutArr_SVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutArr_SVV.Size = new System.Drawing.Size(275, 497);
            this.textBoxOutArr_SVV.TabIndex = 6;
            // 
            // chartFunction_SVV
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_SVV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_SVV.Legends.Add(legend2);
            this.chartFunction_SVV.Location = new System.Drawing.Point(305, 95);
            this.chartFunction_SVV.Name = "chartFunction_SVV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_SVV.Series.Add(series2);
            this.chartFunction_SVV.Size = new System.Drawing.Size(803, 522);
            this.chartFunction_SVV.TabIndex = 6;
            this.chartFunction_SVV.Text = "chart1";
            this.chartFunction_SVV.Click += new System.EventHandler(this.chartFunction_SVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 629);
            this.Controls.Add(this.chartFunction_SVV);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonHelp_SVV_Click);
            this.Controls.Add(this.buttonSave_SVV_Click);
            this.Controls.Add(this.buttonDone_SVV_Click);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 25 | Сафронов В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStopIn_SVV;
        private System.Windows.Forms.TextBox textBoxStartIn_SVV;
        private System.Windows.Forms.Button buttonDone_SVV_Click;
        private System.Windows.Forms.Button buttonSave_SVV_Click;
        private System.Windows.Forms.Button buttonHelp_SVV_Click;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxOutArr_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVV;
    }
}


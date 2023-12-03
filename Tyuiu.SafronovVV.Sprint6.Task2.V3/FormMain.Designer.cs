
namespace Tyuiu.SafronovVV.Sprint6.Task2.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_VSS = new System.Windows.Forms.Button();
            this.buttonHelp_VSS = new System.Windows.Forms.Button();
            this.groupBoxTask1_SVV = new System.Windows.Forms.GroupBox();
            this.groupBoxTask2_SVV = new System.Windows.Forms.GroupBox();
            this.groupBoxTask3_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxStartValue_SVV = new System.Windows.Forms.TextBox();
            this.textBoxStopValue_SVV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUslovie_SVV = new System.Windows.Forms.TextBox();
            this.dataGridViewFunction_SVV = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask1_SVV.SuspendLayout();
            this.groupBoxTask2_SVV.SuspendLayout();
            this.groupBoxTask3_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_VSS
            // 
            this.buttonDone_VSS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_VSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonDone_VSS.Location = new System.Drawing.Point(667, 378);
            this.buttonDone_VSS.Name = "buttonDone_VSS";
            this.buttonDone_VSS.Size = new System.Drawing.Size(130, 42);
            this.buttonDone_VSS.TabIndex = 0;
            this.buttonDone_VSS.Text = "Выполнить";
            this.buttonDone_VSS.UseVisualStyleBackColor = false;
            this.buttonDone_VSS.Click += new System.EventHandler(this.buttonDone_VSS_Click);
            this.buttonDone_VSS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SVV_MouseDown);
            this.buttonDone_VSS.MouseEnter += new System.EventHandler(this.buttonDone_SVV_MouseEnter);
            this.buttonDone_VSS.MouseLeave += new System.EventHandler(this.buttonDone_SVV_MouseLeave);
            // 
            // buttonHelp_VSS
            // 
            this.buttonHelp_VSS.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_VSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonHelp_VSS.Location = new System.Drawing.Point(531, 378);
            this.buttonHelp_VSS.Name = "buttonHelp_VSS";
            this.buttonHelp_VSS.Size = new System.Drawing.Size(130, 42);
            this.buttonHelp_VSS.TabIndex = 1;
            this.buttonHelp_VSS.Text = "Сведенье";
            this.buttonHelp_VSS.UseVisualStyleBackColor = false;
            this.buttonHelp_VSS.Click += new System.EventHandler(this.buttonHelp_VSS_Click);
            // 
            // groupBoxTask1_SVV
            // 
            this.groupBoxTask1_SVV.Controls.Add(this.label2);
            this.groupBoxTask1_SVV.Controls.Add(this.label1);
            this.groupBoxTask1_SVV.Controls.Add(this.textBoxStopValue_SVV);
            this.groupBoxTask1_SVV.Controls.Add(this.textBoxStartValue_SVV);
            this.groupBoxTask1_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxTask1_SVV.Location = new System.Drawing.Point(12, 336);
            this.groupBoxTask1_SVV.Name = "groupBoxTask1_SVV";
            this.groupBoxTask1_SVV.Size = new System.Drawing.Size(504, 102);
            this.groupBoxTask1_SVV.TabIndex = 2;
            this.groupBoxTask1_SVV.TabStop = false;
            this.groupBoxTask1_SVV.Text = "Ввод данных";
            // 
            // groupBoxTask2_SVV
            // 
            this.groupBoxTask2_SVV.Controls.Add(this.chartFunction_SVV);
            this.groupBoxTask2_SVV.Controls.Add(this.dataGridViewFunction_SVV);
            this.groupBoxTask2_SVV.Controls.Add(this.label3);
            this.groupBoxTask2_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxTask2_SVV.Location = new System.Drawing.Point(803, 12);
            this.groupBoxTask2_SVV.Name = "groupBoxTask2_SVV";
            this.groupBoxTask2_SVV.Size = new System.Drawing.Size(551, 426);
            this.groupBoxTask2_SVV.TabIndex = 0;
            this.groupBoxTask2_SVV.TabStop = false;
            this.groupBoxTask2_SVV.Text = "Вывод данных";
            // 
            // groupBoxTask3_SVV
            // 
            this.groupBoxTask3_SVV.Controls.Add(this.textBoxUslovie_SVV);
            this.groupBoxTask3_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxTask3_SVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask3_SVV.Name = "groupBoxTask3_SVV";
            this.groupBoxTask3_SVV.Size = new System.Drawing.Size(785, 318);
            this.groupBoxTask3_SVV.TabIndex = 3;
            this.groupBoxTask3_SVV.TabStop = false;
            this.groupBoxTask3_SVV.Text = "Условие";
            // 
            // textBoxStartValue_SVV
            // 
            this.textBoxStartValue_SVV.Location = new System.Drawing.Point(33, 60);
            this.textBoxStartValue_SVV.Name = "textBoxStartValue_SVV";
            this.textBoxStartValue_SVV.Size = new System.Drawing.Size(190, 24);
            this.textBoxStartValue_SVV.TabIndex = 0;
            // 
            // textBoxStopValue_SVV
            // 
            this.textBoxStopValue_SVV.Location = new System.Drawing.Point(268, 60);
            this.textBoxStopValue_SVV.Name = "textBoxStopValue_SVV";
            this.textBoxStopValue_SVV.Size = new System.Drawing.Size(190, 24);
            this.textBoxStopValue_SVV.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Старт шага:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конец шага:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Результат:";
            // 
            // textBoxUslovie_SVV
            // 
            this.textBoxUslovie_SVV.Location = new System.Drawing.Point(6, 23);
            this.textBoxUslovie_SVV.Multiline = true;
            this.textBoxUslovie_SVV.Name = "textBoxUslovie_SVV";
            this.textBoxUslovie_SVV.ReadOnly = true;
            this.textBoxUslovie_SVV.Size = new System.Drawing.Size(773, 277);
            this.textBoxUslovie_SVV.TabIndex = 6;
            // 
            // dataGridViewFunction_SVV
            // 
            this.dataGridViewFunction_SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SVV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_SVV.Location = new System.Drawing.Point(9, 51);
            this.dataGridViewFunction_SVV.Name = "dataGridViewFunction_SVV";
            this.dataGridViewFunction_SVV.RowHeadersVisible = false;
            this.dataGridViewFunction_SVV.Size = new System.Drawing.Size(118, 369);
            this.dataGridViewFunction_SVV.TabIndex = 6;
            this.dataGridViewFunction_SVV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_SVV_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction_SVV
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_SVV.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_SVV.Legends.Add(legend5);
            this.chartFunction_SVV.Location = new System.Drawing.Point(133, 51);
            this.chartFunction_SVV.Name = "chartFunction_SVV";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_SVV.Series.Add(series5);
            this.chartFunction_SVV.Size = new System.Drawing.Size(431, 369);
            this.chartFunction_SVV.TabIndex = 7;
            this.chartFunction_SVV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 450);
            this.Controls.Add(this.groupBoxTask3_SVV);
            this.Controls.Add(this.groupBoxTask2_SVV);
            this.Controls.Add(this.groupBoxTask1_SVV);
            this.Controls.Add(this.buttonHelp_VSS);
            this.Controls.Add(this.buttonDone_VSS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 3 | Сафронов В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask1_SVV.ResumeLayout(false);
            this.groupBoxTask1_SVV.PerformLayout();
            this.groupBoxTask2_SVV.ResumeLayout(false);
            this.groupBoxTask2_SVV.PerformLayout();
            this.groupBoxTask3_SVV.ResumeLayout(false);
            this.groupBoxTask3_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_VSS;
        private System.Windows.Forms.Button buttonHelp_VSS;
        private System.Windows.Forms.GroupBox groupBoxTask1_SVV;
        private System.Windows.Forms.GroupBox groupBoxTask2_SVV;
        private System.Windows.Forms.GroupBox groupBoxTask3_SVV;
        private System.Windows.Forms.TextBox textBoxStopValue_SVV;
        private System.Windows.Forms.TextBox textBoxStartValue_SVV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUslovie_SVV;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}


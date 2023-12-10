
namespace Tyuiu.SafronovVV.Sprint6.Task5.V7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonResult_SVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_SVV = new System.Windows.Forms.Button();
            this.buttonInfo_SVV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums__SVV = new System.Windows.Forms.DataGridView();
            this.chartGraf__SVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums__SVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf__SVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // buttonResult_SVV
            // 
            this.buttonResult_SVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonResult_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonResult_SVV.Location = new System.Drawing.Point(618, 25);
            this.buttonResult_SVV.Name = "buttonResult_SVV";
            this.buttonResult_SVV.Size = new System.Drawing.Size(153, 65);
            this.buttonResult_SVV.TabIndex = 1;
            this.buttonResult_SVV.Text = "Выполнить";
            this.buttonResult_SVV.UseVisualStyleBackColor = false;
            this.buttonResult_SVV.Click += new System.EventHandler(this.buttonResult_SVV_Click);
            // 
            // buttonOpenFile_SVV
            // 
            this.buttonOpenFile_SVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonOpenFile_SVV.Location = new System.Drawing.Point(777, 25);
            this.buttonOpenFile_SVV.Name = "buttonOpenFile_SVV";
            this.buttonOpenFile_SVV.Size = new System.Drawing.Size(153, 65);
            this.buttonOpenFile_SVV.TabIndex = 2;
            this.buttonOpenFile_SVV.Text = "Открыть файл";
            this.buttonOpenFile_SVV.UseVisualStyleBackColor = false;
            this.buttonOpenFile_SVV.Click += new System.EventHandler(this.buttonOpenFile_SVV_Click);
            // 
            // buttonInfo_SVV
            // 
            this.buttonInfo_SVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonInfo_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonInfo_SVV.Location = new System.Drawing.Point(936, 25);
            this.buttonInfo_SVV.Name = "buttonInfo_SVV";
            this.buttonInfo_SVV.Size = new System.Drawing.Size(153, 65);
            this.buttonInfo_SVV.TabIndex = 3;
            this.buttonInfo_SVV.Text = "Справки";
            this.buttonInfo_SVV.UseVisualStyleBackColor = false;
            this.buttonInfo_SVV.Click += new System.EventHandler(this.buttonInfo_SVV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewNums__SVV);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 475);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewNums__SVV
            // 
            this.dataGridViewNums__SVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums__SVV.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewNums__SVV.Name = "dataGridViewNums__SVV";
            this.dataGridViewNums__SVV.RowHeadersVisible = false;
            this.dataGridViewNums__SVV.Size = new System.Drawing.Size(257, 450);
            this.dataGridViewNums__SVV.TabIndex = 5;
            this.dataGridViewNums__SVV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // chartGraf__SVV
            // 
            this.chartGraf__SVV.BorderlineColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.chartGraf__SVV.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf__SVV.Legends.Add(legend1);
            this.chartGraf__SVV.Location = new System.Drawing.Point(287, 105);
            this.chartGraf__SVV.Name = "chartGraf__SVV";
            this.chartGraf__SVV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf__SVV.Series.Add(series1);
            this.chartGraf__SVV.Size = new System.Drawing.Size(802, 469);
            this.chartGraf__SVV.TabIndex = 5;
            this.chartGraf__SVV.Text = "chart1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(588, 59);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 620);
            this.Controls.Add(this.chartGraf__SVV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonInfo_SVV);
            this.Controls.Add(this.buttonOpenFile_SVV);
            this.Controls.Add(this.buttonResult_SVV);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 7 | Сафронов В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums__SVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf__SVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonResult_SVV;
        private System.Windows.Forms.Button buttonOpenFile_SVV;
        private System.Windows.Forms.Button buttonInfo_SVV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewNums__SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf__SVV;
        private System.Windows.Forms.TextBox textBox1;
    }
}


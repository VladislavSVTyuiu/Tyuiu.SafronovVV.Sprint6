
namespace Tyuiu.SafronovVV.Sprint6.Task6.V1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.groupBoxInPut_SVV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_SVV = new System.Windows.Forms.TextBox();
            this.textBoxOutPut_SVV = new System.Windows.Forms.TextBox();
            this.openFileDialog_SVV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.buttonOpenFile_SVV = new System.Windows.Forms.Button();
            this.groupBoxInPut_SVV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Image = global::Tyuiu.SafronovVV.Sprint6.Task6.V1.Properties.Resources.information;
            this.buttonHelp_SVV.Location = new System.Drawing.Point(725, 12);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(129, 76);
            this.buttonHelp_SVV.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonHelp_SVV, "Сведенье о программе");
            this.buttonHelp_SVV.UseVisualStyleBackColor = true;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // groupBoxInPut_SVV
            // 
            this.groupBoxInPut_SVV.Controls.Add(this.textBox1);
            this.groupBoxInPut_SVV.Location = new System.Drawing.Point(12, 94);
            this.groupBoxInPut_SVV.Name = "groupBoxInPut_SVV";
            this.groupBoxInPut_SVV.Size = new System.Drawing.Size(842, 87);
            this.groupBoxInPut_SVV.TabIndex = 3;
            this.groupBoxInPut_SVV.TabStop = false;
            this.groupBoxInPut_SVV.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(830, 62);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxInPut_SVV);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 450);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ввод данных";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOutPut_SVV);
            this.groupBox3.Location = new System.Drawing.Point(439, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 450);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Вывод данных";
            // 
            // textBoxInPut_SVV
            // 
            this.textBoxInPut_SVV.Location = new System.Drawing.Point(6, 19);
            this.textBoxInPut_SVV.Multiline = true;
            this.textBoxInPut_SVV.Name = "textBoxInPut_SVV";
            this.textBoxInPut_SVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_SVV.Size = new System.Drawing.Size(409, 425);
            this.textBoxInPut_SVV.TabIndex = 6;
            // 
            // textBoxOutPut_SVV
            // 
            this.textBoxOutPut_SVV.Location = new System.Drawing.Point(6, 19);
            this.textBoxOutPut_SVV.Multiline = true;
            this.textBoxOutPut_SVV.Name = "textBoxOutPut_SVV";
            this.textBoxOutPut_SVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_SVV.Size = new System.Drawing.Size(409, 425);
            this.textBoxOutPut_SVV.TabIndex = 7;
            // 
            // openFileDialog_SVV
            // 
            this.openFileDialog_SVV.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка ";
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.Image = global::Tyuiu.SafronovVV.Sprint6.Task6.V1.Properties.Resources.page;
            this.buttonDone_SVV.Location = new System.Drawing.Point(147, 12);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(129, 76);
            this.buttonDone_SVV.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonDone_SVV, "Производит  поиск в файле вхождений символов \"**\"\r\nи конкатенирует строки в котор" +
        "ых находятся \r\nэти символы");
            this.buttonDone_SVV.UseVisualStyleBackColor = true;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            // 
            // buttonOpenFile_SVV
            // 
            this.buttonOpenFile_SVV.Image = global::Tyuiu.SafronovVV.Sprint6.Task6.V1.Properties.Resources.folder_add;
            this.buttonOpenFile_SVV.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_SVV.Name = "buttonOpenFile_SVV";
            this.buttonOpenFile_SVV.Size = new System.Drawing.Size(129, 76);
            this.buttonOpenFile_SVV.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFile_SVV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_SVV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_SVV.Click += new System.EventHandler(this.buttonOpenFile_SVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 649);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxInPut_SVV);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Controls.Add(this.buttonDone_SVV);
            this.Controls.Add(this.buttonOpenFile_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 1 | Сафронов В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxInPut_SVV.ResumeLayout(false);
            this.groupBoxInPut_SVV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.GroupBox groupBoxInPut_SVV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxInPut_SVV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxOutPut_SVV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SVV;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


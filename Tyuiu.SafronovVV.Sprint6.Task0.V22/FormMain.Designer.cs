
namespace Tyuiu.SafronovVV.Sprint6.Task0.V22
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
            this.buttonDone_SVV = new System.Windows.Forms.Button();
            this.buttonHelp_SVV = new System.Windows.Forms.Button();
            this.groupBoxTask_SVV = new System.Windows.Forms.GroupBox();
            this.groupBoxTask1_SVV = new System.Windows.Forms.GroupBox();
            this.groupBoxTask2_SVV = new System.Windows.Forms.GroupBox();
            this.textBoxVarA_SVV = new System.Windows.Forms.TextBox();
            this.textBoxRes_SVV = new System.Windows.Forms.TextBox();
            this.labelTextBox_SVV = new System.Windows.Forms.Label();
            this.labelTextBox2_SVV = new System.Windows.Forms.Label();
            this.labelTextBox3_SVV = new System.Windows.Forms.Label();
            this.textBox_SVV = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_SVV = new System.Windows.Forms.PictureBox();
            this.groupBoxTask4Formula_SVV = new System.Windows.Forms.GroupBox();
            this.groupBoxTask_SVV.SuspendLayout();
            this.groupBoxTask1_SVV.SuspendLayout();
            this.groupBoxTask2_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SVV)).BeginInit();
            this.groupBoxTask4Formula_SVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_SVV
            // 
            this.buttonDone_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonDone_SVV.Location = new System.Drawing.Point(698, 397);
            this.buttonDone_SVV.Name = "buttonDone_SVV";
            this.buttonDone_SVV.Size = new System.Drawing.Size(90, 41);
            this.buttonDone_SVV.TabIndex = 0;
            this.buttonDone_SVV.Text = "Выполнить";
            this.buttonDone_SVV.UseVisualStyleBackColor = true;
            this.buttonDone_SVV.Click += new System.EventHandler(this.buttonDone_SVV_Click);
            // 
            // buttonHelp_SVV
            // 
            this.buttonHelp_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonHelp_SVV.Location = new System.Drawing.Point(535, 397);
            this.buttonHelp_SVV.Name = "buttonHelp_SVV";
            this.buttonHelp_SVV.Size = new System.Drawing.Size(157, 41);
            this.buttonHelp_SVV.TabIndex = 1;
            this.buttonHelp_SVV.Text = "Сведенье о студенте";
            this.buttonHelp_SVV.UseVisualStyleBackColor = true;
            this.buttonHelp_SVV.Click += new System.EventHandler(this.buttonHelp_SVV_Click);
            // 
            // groupBoxTask_SVV
            // 
            this.groupBoxTask_SVV.Controls.Add(this.textBox_SVV);
            this.groupBoxTask_SVV.Controls.Add(this.groupBoxTask4Formula_SVV);
            this.groupBoxTask_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxTask_SVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SVV.Name = "groupBoxTask_SVV";
            this.groupBoxTask_SVV.Size = new System.Drawing.Size(776, 232);
            this.groupBoxTask_SVV.TabIndex = 2;
            this.groupBoxTask_SVV.TabStop = false;
            this.groupBoxTask_SVV.Text = "Условие";
            // 
            // groupBoxTask1_SVV
            // 
            this.groupBoxTask1_SVV.Controls.Add(this.labelTextBox3_SVV);
            this.groupBoxTask1_SVV.Controls.Add(this.labelTextBox_SVV);
            this.groupBoxTask1_SVV.Controls.Add(this.textBoxVarA_SVV);
            this.groupBoxTask1_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxTask1_SVV.Location = new System.Drawing.Point(12, 269);
            this.groupBoxTask1_SVV.Name = "groupBoxTask1_SVV";
            this.groupBoxTask1_SVV.Size = new System.Drawing.Size(250, 169);
            this.groupBoxTask1_SVV.TabIndex = 0;
            this.groupBoxTask1_SVV.TabStop = false;
            this.groupBoxTask1_SVV.Text = "Ввод данных";
            // 
            // groupBoxTask2_SVV
            // 
            this.groupBoxTask2_SVV.Controls.Add(this.labelTextBox2_SVV);
            this.groupBoxTask2_SVV.Controls.Add(this.textBoxRes_SVV);
            this.groupBoxTask2_SVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.groupBoxTask2_SVV.Location = new System.Drawing.Point(279, 269);
            this.groupBoxTask2_SVV.Name = "groupBoxTask2_SVV";
            this.groupBoxTask2_SVV.Size = new System.Drawing.Size(250, 169);
            this.groupBoxTask2_SVV.TabIndex = 0;
            this.groupBoxTask2_SVV.TabStop = false;
            this.groupBoxTask2_SVV.Text = "Вывод данных";
            // 
            // textBoxVarA_SVV
            // 
            this.textBoxVarA_SVV.Location = new System.Drawing.Point(53, 85);
            this.textBoxVarA_SVV.Name = "textBoxVarA_SVV";
            this.textBoxVarA_SVV.Size = new System.Drawing.Size(164, 24);
            this.textBoxVarA_SVV.TabIndex = 3;
            this.textBoxVarA_SVV.TextChanged += new System.EventHandler(this.textBoxVarA_SVV_TextChanged);
            this.textBoxVarA_SVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarA_KeyPress);
            // 
            // textBoxRes_SVV
            // 
            this.textBoxRes_SVV.Location = new System.Drawing.Point(46, 85);
            this.textBoxRes_SVV.Name = "textBoxRes_SVV";
            this.textBoxRes_SVV.ReadOnly = true;
            this.textBoxRes_SVV.Size = new System.Drawing.Size(156, 24);
            this.textBoxRes_SVV.TabIndex = 4;
            this.textBoxRes_SVV.TextChanged += new System.EventHandler(this.textBoxRes_SVV_TextChanged);
            // 
            // labelTextBox_SVV
            // 
            this.labelTextBox_SVV.AutoSize = true;
            this.labelTextBox_SVV.Location = new System.Drawing.Point(50, 64);
            this.labelTextBox_SVV.Name = "labelTextBox_SVV";
            this.labelTextBox_SVV.Size = new System.Drawing.Size(112, 18);
            this.labelTextBox_SVV.TabIndex = 3;
            this.labelTextBox_SVV.Text = "Переменная X:";
            // 
            // labelTextBox2_SVV
            // 
            this.labelTextBox2_SVV.AutoSize = true;
            this.labelTextBox2_SVV.Location = new System.Drawing.Point(43, 64);
            this.labelTextBox2_SVV.Name = "labelTextBox2_SVV";
            this.labelTextBox2_SVV.Size = new System.Drawing.Size(84, 18);
            this.labelTextBox2_SVV.TabIndex = 5;
            this.labelTextBox2_SVV.Text = "Результат:";
            // 
            // labelTextBox3_SVV
            // 
            this.labelTextBox3_SVV.AutoSize = true;
            this.labelTextBox3_SVV.Location = new System.Drawing.Point(6, 88);
            this.labelTextBox3_SVV.Name = "labelTextBox3_SVV";
            this.labelTextBox3_SVV.Size = new System.Drawing.Size(41, 18);
            this.labelTextBox3_SVV.TabIndex = 3;
            this.labelTextBox3_SVV.Text = "(X) =";
            this.labelTextBox3_SVV.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_SVV
            // 
            this.textBox_SVV.Location = new System.Drawing.Point(16, 32);
            this.textBox_SVV.Multiline = true;
            this.textBox_SVV.Name = "textBox_SVV";
            this.textBox_SVV.ReadOnly = true;
            this.textBox_SVV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_SVV.Size = new System.Drawing.Size(456, 171);
            this.textBox_SVV.TabIndex = 6;
            this.textBox_SVV.Text = "Выполнить выражение по формуле";
            // 
            // pictureBoxFormula_SVV
            // 
            this.pictureBoxFormula_SVV.Image = global::Tyuiu.SafronovVV.Sprint6.Task0.V22.Properties.Resources.Tyuiu_SafronovVV_Sprint6_Task0_V22;
            this.pictureBoxFormula_SVV.InitialImage = null;
            this.pictureBoxFormula_SVV.Location = new System.Drawing.Point(24, 72);
            this.pictureBoxFormula_SVV.Name = "pictureBoxFormula_SVV";
            this.pictureBoxFormula_SVV.Size = new System.Drawing.Size(217, 41);
            this.pictureBoxFormula_SVV.TabIndex = 7;
            this.pictureBoxFormula_SVV.TabStop = false;
            this.pictureBoxFormula_SVV.Click += new System.EventHandler(this.pictureBoxFormula_SVV_Click);
            // 
            // groupBoxTask4Formula_SVV
            // 
            this.groupBoxTask4Formula_SVV.Controls.Add(this.pictureBoxFormula_SVV);
            this.groupBoxTask4Formula_SVV.Location = new System.Drawing.Point(492, 23);
            this.groupBoxTask4Formula_SVV.Name = "groupBoxTask4Formula_SVV";
            this.groupBoxTask4Formula_SVV.Size = new System.Drawing.Size(264, 180);
            this.groupBoxTask4Formula_SVV.TabIndex = 8;
            this.groupBoxTask4Formula_SVV.TabStop = false;
            this.groupBoxTask4Formula_SVV.Text = "Выражение";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTask2_SVV);
            this.Controls.Add(this.groupBoxTask1_SVV);
            this.Controls.Add(this.groupBoxTask_SVV);
            this.Controls.Add(this.buttonHelp_SVV);
            this.Controls.Add(this.buttonDone_SVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 22 | Сафронов В.В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SVV.ResumeLayout(false);
            this.groupBoxTask_SVV.PerformLayout();
            this.groupBoxTask1_SVV.ResumeLayout(false);
            this.groupBoxTask1_SVV.PerformLayout();
            this.groupBoxTask2_SVV.ResumeLayout(false);
            this.groupBoxTask2_SVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_SVV)).EndInit();
            this.groupBoxTask4Formula_SVV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.GroupBox groupBoxTask_SVV;
        private System.Windows.Forms.GroupBox groupBoxTask1_SVV;
        private System.Windows.Forms.GroupBox groupBoxTask2_SVV;
        private System.Windows.Forms.TextBox textBoxVarA_SVV;
        private System.Windows.Forms.TextBox textBoxRes_SVV;
        private System.Windows.Forms.Label labelTextBox3_SVV;
        private System.Windows.Forms.Label labelTextBox_SVV;
        private System.Windows.Forms.Label labelTextBox2_SVV;
        private System.Windows.Forms.PictureBox pictureBoxFormula_SVV;
        private System.Windows.Forms.TextBox textBox_SVV;
        private System.Windows.Forms.GroupBox groupBoxTask4Formula_SVV;
    }
}


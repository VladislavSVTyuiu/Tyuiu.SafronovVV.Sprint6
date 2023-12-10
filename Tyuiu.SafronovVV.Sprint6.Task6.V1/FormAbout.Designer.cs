
namespace Tyuiu.SafronovVV.Sprint6.Task6.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_SVV = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_SVV
            // 
            this.labelInfo_SVV.AutoSize = true;
            this.labelInfo_SVV.Location = new System.Drawing.Point(220, 9);
            this.labelInfo_SVV.Name = "labelInfo_SVV";
            this.labelInfo_SVV.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_SVV.TabIndex = 1;
            this.labelInfo_SVV.Text = resources.GetString("labelInfo_SVV.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.SafronovVV.Sprint6.Task6.V1.Properties.Resources.Tyuiu_SafronovVV_Sprint6_Task6_V;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 269);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 281);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInfo_SVV);
            this.Name = "FormAbout";
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfo_SVV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SafronovVV.Sprint6.Task6.V1.Lib;
using System.IO;



namespace Tyuiu.SafronovVV.Sprint6.Task6.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_SVV_Click(object sender, EventArgs e)
        {
            openFileDialog_SVV.ShowDialog();
            openFilePath = openFileDialog_SVV.FileName;
            textBoxInPut_SVV.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SVV.Text = groupBoxInPut_SVV.Text + " " + openFileDialog_SVV.FileName;
            buttonDone_SVV.Enabled = true;
        }

        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            string resStr = "";
            textBoxOutPut_SVV.Text = ds.CollectTextFromFile(resStr, openFilePath);
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}

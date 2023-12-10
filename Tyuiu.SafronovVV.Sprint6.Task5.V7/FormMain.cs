using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SafronovVV.Sprint6.Task5.V7.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task5.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"C:\DataSprint6\InPutFileTask5V7.txt";


        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonResult_SVV_Click(object sender, EventArgs e)
        {
            dataGridViewNums__SVV.ColumnCount = 2;
            dataGridViewNums__SVV.Columns[0].Width = 20;
            dataGridViewNums__SVV.Columns[1].Width = 50;
            this.chartGraf__SVV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraf__SVV.ChartAreas[0].AxisY.Title = "Ось Y";
            chartGraf__SVV.Series[0].Points.Clear();
            double[] massive = new double[ds.len];
            massive = ds.LoadFromDataFile(path);
            for (int i = 0; i < massive.Length; i++)
            {
                dataGridViewNums__SVV.Rows.Add(Convert.ToString(i), Convert.ToString(massive[i]));
                chartGraf__SVV.Series[0].Points.AddXY(i, massive[i]);
            }
        }

        private void buttonOpenFile_SVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-1 Сафронов Владислав Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

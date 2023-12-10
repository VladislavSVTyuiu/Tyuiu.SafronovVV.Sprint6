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

using Tyuiu.SafronovVV.Sprint6.Task4.V25.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task4.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartIn_SVV.Text);
                int stop = Convert.ToInt32(textBoxStopIn_SVV.Text);
                int len = stop - start + 1;
                double[] array = ds.GetMassFunction(start, stop);

                textBoxOutArr_SVV.Text = "";
                chartFunction_SVV.Series[0].Points.Clear();
                this.chartFunction_SVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SVV.ChartAreas[0].AxisY.Title = "Ось y";

                for (int i = 0; i < len; i++)
                {
                    textBoxOutArr_SVV.AppendText(Convert.ToString(array[i]) + Environment.NewLine);
                    chartFunction_SVV.Series[0].Points.AddXY(start, array[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_SVV_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_SVV_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-1 Сафронов Владислав Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_SVV_Click_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V25.txt";
                File.WriteAllText(path, textBoxOutArr_SVV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

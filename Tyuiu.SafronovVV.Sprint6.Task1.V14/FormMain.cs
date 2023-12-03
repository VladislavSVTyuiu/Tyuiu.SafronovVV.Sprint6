using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SafronovVV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_VSS_Click(object sender, EventArgs e)
        {
            DataService service1 = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_SVV.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_SVV.Text);

                string strLine;

                int len = service1.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = service1.GetMassFunction(startStep, stopStep);
                textBoxRezult_VSS.Text = "";
                textBoxRezult_VSS.AppendText("+--------+---------+" + Environment.NewLine);
                textBoxRezult_VSS.AppendText("|    x   |   f(x)  |" + Environment.NewLine);
                textBoxRezult_VSS.AppendText("+--------+---------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   | {1,5:f2}   |", startStep, valueArray[i]);
                    textBoxRezult_VSS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRezult_VSS.AppendText("+--------+---------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_VSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУБ-23-1 Cафронов Владислав Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStartValue_SVV_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

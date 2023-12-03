using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SafronovVV.Sprint6.Task2.V3.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task2.V3
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
            DataService ds = new DataService();
            try
            {
                int startValue = int.Parse(textBoxStartValue_SVV.Text);
                int stopValue = int.Parse(textBoxStopValue_SVV.Text);

                double[] array = ds.GetMassFunction(startValue, stopValue);

                chartFunction_SVV.Titles.Add("График функции f(x)");
                chartFunction_SVV.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_SVV.ChartAreas[0].AxisY.Title = "Ось Y";
                for (global::System.Int32 i = 0; i < array.Length; i++)
                {
                    dataGridViewFunction_SVV.Rows.Add(startValue.ToString(), array[i].ToString());
                    chartFunction_SVV.Series[0].Points.AddXY(startValue, array[i]);
                    startValue++;
                }

            }

            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFunction_SVV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonHelp_VSS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-1 Cафронов Владислав Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_SVV_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_SVV_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void buttonDone_SVV_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}

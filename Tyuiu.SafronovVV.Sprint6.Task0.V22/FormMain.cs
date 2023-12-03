using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SafronovVV.Sprint6.Task0.V22.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task0.V22
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

        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRes_SVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA_SVV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУБ-23-1 Cафронов Владислав Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxVarA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }

        }

        private void textBoxVarA_SVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRes_SVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFormula_SVV_Click(object sender, EventArgs e)
        {

        }
    }
}

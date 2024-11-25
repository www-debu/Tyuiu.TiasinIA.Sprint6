using Tyuiu.TiasinIA.Sprint6.Task1.V16.Lib;

namespace Tyuiu.TiasinIA.Sprint6.Task1.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonStrt_tia_Click(object sender, EventArgs e)
        {
            try
            {

                int startStep = Convert.ToInt32(textBoxone_tia.Text);
                int stopStep = Convert.ToInt32(textBoxtwo_tia.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxR_tia.Text = "";
                textBoxR_tia.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxR_tia.AppendText("|    X     |    f(x)    |" + Environment.NewLine);
                textBoxR_tia.AppendText("+----------+------------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}    |", startStep, valueArray[i]);
                    textBoxR_tia.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxR_tia.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void textBoxtwo_tia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Выполнил студент группы АСОиУБ-24-1 Тясин Илья Александрович");
        }

        private void textBoxResult_tia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

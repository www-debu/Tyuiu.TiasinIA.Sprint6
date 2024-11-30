using Tyuiu.TiasinIA.Sprint6.Task2.V7.Lib;
namespace Tyuiu.TiasinIA.Sprint6.Task2.V7
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

        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 Выполнил студент группы АСОиУБ-24-1 Тясин Илья Александрович");
        }

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

                this.chart_tia.Titles.Add("График функции Sin(x)");

                this.chart_tia.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_tia.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGrid_tia.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart_tia.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
        private void buttonStrt_tia_MouseEnter(object sender, EventArgs e)
        {
            buttonStrt_tia.BackColor = Color.Red;
        }

        private void buttonStrt_tia_MouseLeave(object sender, EventArgs e)
        {
            buttonStrt_tia.BackColor = Color.Blue;
        }
    }
}

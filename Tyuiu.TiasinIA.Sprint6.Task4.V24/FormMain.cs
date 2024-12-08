using Tyuiu.TiasinIA.Sprint6.Task4.V24.Lib;
namespace Tyuiu.TiasinIA.Sprint6.Task4.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 Выполнил студент группы АСОиУБ-24-1 Тясин Илья Александрович");
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

                textBoxResult_tia.Text = "";

                chart_tia.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chart_tia.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_tia.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_tia_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_tia.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "Notepad.exe";
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

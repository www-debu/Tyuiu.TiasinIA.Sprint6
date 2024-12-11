using System.Reflection;
using Tyuiu.TiasinIA.Sprint6.Task5.V23.Lib;
namespace Tyuiu.TiasinIA.Sprint6.Task5.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C: User\www\source\repos\Tyuiu.TiasinIA.Sprint6\Tyuiu.TiasinIA.Sprint6.Task5.V23\bin\Debug\OutPutFileTask5.txt";
        private void pictureBox1_tia_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 Выполнил студент группы АСОиУБ-24-1 Тясин Илья Александрович");
        }

        private void buttonStrt_tia_Click(object sender, EventArgs e)
        {
            dataGridView_tia.ColumnCount = 2;
            dataGridView_tia.Columns[0].Width = 20;
            dataGridView_tia.Columns[1].Width = 50;

            this.chart_tia.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chart_tia.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_tia.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridView_tia.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart_tia.Series[0].Points.AddXY(i, numsMass[i]);

            }
        }

        private void button_File_tia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}

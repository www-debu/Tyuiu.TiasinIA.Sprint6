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
            MessageBox.Show("Таск 2 Выполнил студент группы АСОиУБ-24-1 Тясин Илья Александрович");
        }

        private void buttonStrt_tia_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Colums[0].Width = 20;
            dataGridViewNums.Cplums[1].Width = 50;

            this.chart_tia.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chart_tia.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_tia.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++) 
            {
                data

        }
    }
}

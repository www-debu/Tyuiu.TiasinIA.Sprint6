using System.Drawing.Drawing2D;
using Tyuiu.TiasinIA.Sprint6.Task3.V15.Lib;
namespace Tyuiu.TiasinIA.Sprint6.Task3.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] {   { 33, 28, 31, 19, 4 },
                                        { 1, 32, -3, -17, -12 },
                                        { 24, -19, 26, 31, -3 },
                                        { 30, -16, 29, 28, 8 },
                                        { 30, 5, 11, 7, 32 } };

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_tia_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 Выполнил студент группы АСОиУБ-24-1 Тясин Илья Александрович");
        }

        private void buttonStrt_tia_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(mtrx);
            string output = "";


            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    output += result[i, j].ToString().PadLeft(4) + " ";
                }
                output += Environment.NewLine;
            }

            textBoxResult_tia.Text = output;

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int colums = mtrx.Length / rows;

            dataGrid_tia.ColumnCount = colums;
            dataGrid_tia.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGrid_tia.Columns[i].Width = 100;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    dataGrid_tia.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void dataGrid_tia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

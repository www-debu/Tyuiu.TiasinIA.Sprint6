using Tyuiu.TiasinIA.Sprint6.Task0.V3.Lib;
namespace Tyuiu.TiasinIA.Sprint6.Task0.V3
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

        private void buttonfst_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_tia.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxone_tia.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBoxone_tia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelpClick_tia_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ������-24-1 ����� ���� �������������");
        }

        private void textBoxd_tia_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelpClick_tia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ ������-24-1 ����� ���� �������������");
        }
    }
}

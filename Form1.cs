using HiH_VP_Project_.Formss;
using System.Diagnostics.Eventing.Reader;

namespace HiH_VP_Project_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "123")
            {
                login();
            }
            else
            {
                MessageBox.Show("Invalid Entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void login()
        {
            Dashboard m = new Dashboard();
            m.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
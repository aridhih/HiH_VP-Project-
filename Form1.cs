using HiH_VP_Project_.Formss;

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
            Dashboard m = new Dashboard();
            m.Show();
            this.Hide();
        }
    }
}
using HiH_VP_Project_.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiH_VP_Project_.Formss
{
    public partial class BookAppointmnet : Form
    {
        Patient p = new Patient();
        Doctor d = new Doctor();
        DateOnly dtm = new DateOnly();
        
        public BookAppointmnet()
        {
            InitializeComponent();
        }

        private void BookAppointmnet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.read();
            dataGridView2.DataSource = d.read();
            textBox3.Text = dtm.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

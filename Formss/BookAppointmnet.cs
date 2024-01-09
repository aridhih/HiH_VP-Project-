using HiH_VP_Project_.Classes;
using System.Text.RegularExpressions;

namespace HiH_VP_Project_.Formss
{
    public partial class BookAppointmnet : Form
    {
        Patient p = new Patient();
        Doctor d = new Doctor();
        appointments ap = new appointments();
        DateTime dtm = DateTime.Now;


        public BookAppointmnet()
        {
            InitializeComponent();
        }

        private void BookAppointmnet_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.read();
            dataGridView2.DataSource = d.read();
            textBox3.Text = dtm.Month.ToString() + "/" + dtm.DayOfYear.ToString() + "/" + dtm.Year.ToString();

            dataGridView3.DataSource = ap.read();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.ColumnIndex;
            if (a < 0)
            {
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            }
            else
            {
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[0].Value);

            }
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.ColumnIndex;
            if (a < 0)
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

            }
            else
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[0].Value);

            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.ColumnIndex;
            if (a < 0)
            {
                ap.Appointment_id1 = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].Value);
                textBox4.Text = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[1].Value);
                textBox1.Text = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[2].Value);
                textBox2.Text = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[4].Value);
                textBox3.Text = Convert.ToString(dataGridView3.Rows[e.RowIndex].Cells[3].Value);
            }
            else
            {
                ap.Appointment_id1 = Convert.ToInt32(dataGridView3.Rows[e.ColumnIndex].Cells[0].Value);
                textBox4.Text = Convert.ToString(dataGridView3.Rows[e.ColumnIndex].Cells[1].Value);
                textBox1.Text = Convert.ToString(dataGridView3.Rows[e.ColumnIndex].Cells[2].Value);
                textBox2.Text = Convert.ToString(dataGridView3.Rows[e.ColumnIndex].Cells[4].Value);
                textBox3.Text = Convert.ToString(dataGridView3.Rows[e.ColumnIndex].Cells[3].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isValid())
            {
                ap.Patient_id1 = Convert.ToInt32(textBox4.Text);
                ap.Doctor_id1 = Convert.ToInt32(textBox1.Text);
                ap.Date1 = textBox3.Text;
                ap.Time1 = textBox2.Text;
                ap.create();
                dataGridView3.DataSource = ap.read();
                MessageBox.Show("Appointment Booked.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }

        }
        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Patient ID is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.IndianRed;
                textBox4.Focus();
                return false;
            }

            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Doctor ID is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.BackColor = Color.IndianRed;
                textBox1.Focus();

                return false;
            }



            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Appointment Date is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.BackColor = Color.IndianRed;
                textBox3.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Appointment Time is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.IndianRed;
                textBox2.Focus();
                return false;
            }
            else if (textBox2.Text.Length > 4)
            {
                MessageBox.Show("PLease Check Time Format( e.g: 12AM )", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.IndianRed;
                textBox2.Focus();
                return false;
            }

            return true;

        }

        public void reset()

        {
            ap.Appointment_id1 = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            dataGridView3.DataSource = ap.read();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ap.Appointment_id1 > 0)
            {
                ap.delete(ap.Appointment_id1);

                dataGridView3.DataSource = ap.read();
                reset();
                MessageBox.Show("Appointment Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Select a Record to Delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dashboard ap = new Dashboard();
            ap.Show();
            this.Close();
        }
    }
}


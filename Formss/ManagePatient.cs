using HiH_VP_Project_.Classes;

namespace HiH_VP_Project_.Formss
{
    public partial class patient : Form
    {
        Patient p = new Patient();
        public patient()
        {
            InitializeComponent();
        }

        private void patient_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = p.read();
           

        }



        private void textBox4_TextChanged(object sender, EventArgs e)

        {
            textBox4.BackColor = Color.White;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
                textBox4.Clear();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                p.Name1 = textBox1.Text;
                p.Address1 = textBox2.Text;
                p.Patient_email1 = textBox3.Text;
                p.Phone1 = Convert.ToDouble(textBox4.Text);
                p.create();

                dataGridView1.DataSource = p.read();
                MessageBox.Show("Patient Successfully Added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }

        }

        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Patient Name is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.BackColor = Color.IndianRed;
                textBox1.Focus();

                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Patient Address is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.IndianRed;
                textBox2.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Patient Email is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.BackColor = Color.IndianRed;
                textBox3.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Patient Phone No is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.IndianRed;
                textBox4.Focus();
                return false;
            }
            else if (textBox4.Text.Length != 10)
            {
                MessageBox.Show("'Phone No' must have  10-Digits", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.IndianRed;
                textBox4.Focus();
                return false;
            }

            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = p.read();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.ColumnIndex;
            if (a < 0)
            {
                p.Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            }
            else
            {
                p.Id = Convert.ToInt32(dataGridView1.Rows[e.ColumnIndex].Cells[0].Value);
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[2].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[4].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[3].Value);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (p.Id > 0)
            {
                p.Name1 = textBox1.Text;
                p.Address1 = textBox2.Text;
                p.Patient_email1 = textBox3.Text;
                p.Phone1 = Convert.ToDouble(textBox4.Text);


                p.update();

                dataGridView1.DataSource = p.read();
                MessageBox.Show("Patient Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
                MessageBox.Show("Please Select a Record to Update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (p.Id > 0)
            {
                p.delete(p.Id);

                dataGridView1.DataSource = p.read();
                reset();
                MessageBox.Show("Patient Successfully Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Select a Record to Delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        public void reset()

        {
            p.Id = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }
        
    }
}

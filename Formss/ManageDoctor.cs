using HiH_VP_Project_.Classes;

namespace HiH_VP_Project_.Formss
{
    public partial class ManageDoctor : Form
    {

        Doctor d = new Doctor();
        public ManageDoctor()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                d.Name1 = textBox1.Text;
                d.Phone1 = Convert.ToDouble(textBox2.Text);
                d.Email1 = textBox3.Text;
                d.Location1 = textBox4.Text;
                d.create();

                dataGridView1.DataSource = d.read();
                MessageBox.Show("Doctor Successfully Added.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reset();
            }

        }
        private bool isValid()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Doctor Name is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.BackColor = Color.IndianRed;
                textBox1.Focus();

                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Doctor Phone is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.IndianRed;
                textBox2.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Doctor Email is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.BackColor = Color.IndianRed;
                textBox3.Focus();
                return false;
            }
            else if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Doctor Location is Missing", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.IndianRed;
                textBox4.Focus();
                return false;
            }
            else if (textBox2.Text.Length != 10)
            {
                MessageBox.Show("'Phone No' must have  10-Digits", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.BackColor = Color.IndianRed;
                textBox2.Focus();
                return false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox3.Text, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
            {



                MessageBox.Show("Please enter valid Email Address (abc@xyz.com).", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.BackColor = Color.IndianRed;
                textBox4.Focus();
                textBox3.Clear();
                return false;
            }

            return true;
        }

        public void reset()

        {
            d.Doctor_id1 = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = d.read();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.ColumnIndex;
            if (a < 0)
            {
                d.Doctor_id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            }
            else
            {
                d.Doctor_id1 = Convert.ToInt32(dataGridView1.Rows[e.ColumnIndex].Cells[0].Value);
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[2].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[4].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.ColumnIndex].Cells[3].Value);
            }
        }

        private void ManageDoctor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = d.read();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (d.Doctor_id1 > 0)
            {
                d.Name1 = textBox1.Text;
                d.Phone1 = Convert.ToDouble(textBox2.Text);
                d.Email1 = textBox3.Text;
                d.Location1 = textBox4.Text;


                d.update();

                dataGridView1.DataSource = d.read();
                MessageBox.Show("Doctor Successfully Updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reset();
            }
            else
                MessageBox.Show("Please Select a Record to Update.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (d.Doctor_id1 > 0)
            {
                d.delete(d.Doctor_id1);

                dataGridView1.DataSource = d.read();
                reset();
                MessageBox.Show("Doctor Successfully Deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Please Select a Record to Delete.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}

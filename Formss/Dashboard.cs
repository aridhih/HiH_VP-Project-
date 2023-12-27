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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            patient p = new patient();
            p.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageDoctor doc = new ManageDoctor();
            doc.Show();
            this.Close();
        }
    }
}

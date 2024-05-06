using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PremService : Form
    {
        public PremService()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerService customerService = new CustomerService();
            customerService.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("?ايش لونك?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("هات بونص الاول");
        }
    }
}

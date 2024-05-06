using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class customerLogin : Form
    {
        public customerLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            CustomerService customerService = new CustomerService();
            customerService.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Your SSN!");
            }
            else if (SharedData.dis == "T")
            {
                SharedData.ssn = textBox2.Text;
                this.Hide();
                Transactions t = new Transactions();
                t.Show();
            }
            else if (SharedData.dis == "P")
            {
                if (DataStorage.StringPriorityQueue.IsEmpty)
                {
                    MessageBox.Show("You can't access premium services!");
                }
                else if (DataStorage.StringPriorityQueue.PeekString() == textBox2.Text)
                {
                    SharedData.ssn = textBox2.Text;
                    this.Hide();
                    PremService t = new PremService();
                    t.Show();
                }
                else
                {
                    MessageBox.Show("You can't access premium services!");
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class CustomerService : Form
    {
        public CustomerService()
        {
            InitializeComponent();
        }

        private void CustomerService_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            OldUser oldUser = new OldUser();
            oldUser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataStorage.StringStack.Count == 0) MessageBox.Show("there is no previous transactions!");
            else
            {
                Inquiry frm = new Inquiry();
                frm.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SharedData.dis = "T";
            customerLogin transactions = new customerLogin();
            transactions.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SharedData.dis = "P";
            customerLogin customerLogin = new customerLogin();
            customerLogin.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

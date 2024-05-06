using System;
using System.Collections;
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
    public partial class Inquiry : Form
    {
        public Inquiry()
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
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataStorage.StringStack.Count == 0)
            {
                MessageBox.Show("There is no Previous transactions!");
                textBox1.Text = ""; textBox2.Text = "";
            }
            else
            {
                string poppedElement = DataStorage.StringStack.Pop();

                // Display the next top of the queue
                if (DataStorage.StringStack.Count > 0)
                {
                    string nextTopElement = DataStorage.StringStack.Peek();

                    string s = DataStorage.StringStack.Peek();
                    string x = "";
                    for (int i = 1; i < s.Length; i++)
                    {
                        x += s[i];
                    }
                    textBox1.Text = x;



                    string s2 = DataStorage.StringStack.Peek();
                    string x2;
                    if (s[0] == 'W') x2 = "Withdraw";
                    else x2 = "Deposite";
                    textBox2.Text = x2;


                }
                else
                {
                    MessageBox.Show("There is no Previous transactions!");
                    textBox1.Text = ""; textBox2.Text = "";
                }
            }

        }

        private void Inquiry_Load(object sender, EventArgs e)
        {
            if (DataStorage.StringStack.Count == 0)
            {
                MessageBox.Show("There is no Previous transactions!");
                textBox1.Text = ""; textBox2.Text = "";
            }
            else
            {
                string s = DataStorage.StringStack.Peek();
                string x = "";
                for (int i = 1; i < s.Length; i++)
                {
                    x += s[i];
                }
                textBox1.Text = x;

                string s2 = DataStorage.StringStack.Peek();
                string x2;
                if (s[0] == 'w') x2 = "Withdraw";
                else x2 = "Deposite";
                textBox2.Text = (x2);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class EmployeeRequest : Form
    {
        public EmployeeRequest()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            employeeService oldUser = new employeeService();
            oldUser.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStorage.StringLinkedList.AddLast(SharedData.c  +"  "+ textBox2.Text+"  " + textBox1.Text);SharedData.c++;

            string poppedElement;
            if (DataStorage.StringQueue.Count == 0) {
                MessageBox.Show("There is no requests"); textBox1.Text = "";textBox2.Text = "";
            }
            else poppedElement = DataStorage.StringQueue.Dequeue();

           
            if (DataStorage.StringQueue.Count > 0)
            {
                string nextTopElement = DataStorage.StringQueue.Peek();

                string s = DataStorage.StringQueue.Peek();
                string x = "";
                for (int i = 0; i < 10; i++) { x += s[i]; }
                textBox1.Text = x;



                string s2 = DataStorage.StringQueue.Peek();
                string x2 = "";
                for (int i = 10; i < s.Length; i++) { x2 += s[i]; }
                textBox2.Text = x2;



            }
            else
            {
                MessageBox.Show("There is no requests!");
                textBox1.Text = ""; textBox2.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeRequest_Load(object sender, EventArgs e)
        {
            if (DataStorage.StringQueue.Count == 0) { MessageBox.Show("There is no requests"); textBox1.Text = ""; textBox2.Text = ""; }
            else
            {
                string s = DataStorage.StringQueue.Peek();
                string x = "";
                for (int i = 10; i < s.Length; i++) { x += s[i]; }
                textBox2.Text = x;

                string s2 = DataStorage.StringQueue.Peek();
                string x2 = "";
                for (int i = 0; i < 10; i++) { x2 += s[i]; }
                textBox1.Text = x2;
            }
        }
    }
}

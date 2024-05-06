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
    public partial class viewCustomers : Form
    {
        public viewCustomers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            employeeService employeeService = new employeeService();
            employeeService.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewCustomers_Load(object sender, EventArgs e)
        {
            textBox2.Clear();
            foreach (var item in DataStorage.StringLinkedList)
            {
                textBox2.AppendText(item + Environment.NewLine);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataStorage.StringLinkedList.Any())
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter the number you want to remove!");
                }
                else
                {
                    int x = 1;
                    var itemsToRemove = DataStorage.StringLinkedList.Where(item => item.StartsWith(textBox1.Text)).ToList();
                    foreach (var item in itemsToRemove)
                    {
                        DataStorage.StringLinkedList.Remove(item);
                        textBox1.Text = "";
                        x = 0;
                    }

                    if (x == 1)
                    {
                        MessageBox.Show("There is no such customer!");
                        textBox1.Text = "";
                    }

                    textBox2.Clear();
                    foreach (var item in DataStorage.StringLinkedList)
                    {
                        textBox2.AppendText(item + Environment.NewLine);
                    }
                }
            }
            else MessageBox.Show("No more customers!");
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class employeeService : Form
    {
        public employeeService()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OldUser oldUser = new OldUser();
            oldUser.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataStorage.StringQueue.Count == 0) MessageBox.Show("There is no requests!");
            else
            {
                EmployeeRequest employeeRequest = new EmployeeRequest();
                employeeRequest.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataStorage.StringLinkedList.Any())
            {
                viewCustomers view = new viewCustomers();
                view.Show();
                this.Hide();
            }
            else MessageBox.Show("No customers yet!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

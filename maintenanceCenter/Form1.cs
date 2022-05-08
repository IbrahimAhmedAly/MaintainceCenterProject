using maintenanceCenter.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenanceCenter
{
    public partial class Form1 : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = db.Users.
                FirstOrDefault(u => u.UserName == txtName.Text && u.Password == txtPassword.Text);

            if(user != null)
            {

                if (txtName.Text == "Admin" && txtPassword.Text == "admincap")
                {
                    MainForm frm = new MainForm(txtName.Text, txtPassword.Text);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MainForm frm = new MainForm(txtName.Text, txtPassword.Text);
                    frm.Show();
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("User name or password are in valid!");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

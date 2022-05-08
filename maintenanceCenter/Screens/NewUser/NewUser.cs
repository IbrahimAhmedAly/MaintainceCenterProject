using maintenanceCenter.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenanceCenter.Screens.NewUser
{
    public partial class NewUser : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();

        public NewUser()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات المطلوبة");
                return;
            }
                
            User user = new User
            {
                UserName = txtName.Text,
                Password = txtPassword.Text
            };
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("تم الحفظ");
            txtName.Text = "";
            txtPassword.Text = "";
            
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }
    }
}

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

namespace maintenanceCenter.Screens.Technicals
{
    public partial class AddTechnical : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();

        public AddTechnical()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
                MessageBox.Show("برجاء ادخال البيانات المطلوبة");
            else if (db.Technicals.Where(t => t.Name == txtName.Text).Count() > 0)
            {
                MessageBox.Show("هذا الفني موجود بالفعل");
            }
            else
            {
                Technical tech = new Technical();
                tech.Name = txtName.Text;
                db.Technicals.Add(tech);
                db.SaveChanges();
                MessageBox.Show("تم الحفظ");
                txtName.Text = "";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}

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
    public partial class ViewTechniclas : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();
        int id;
        Technical tech;
        public ViewTechniclas()
        {
            InitializeComponent();
            TechnicalsDGV.DataSource = db.Technicals.ToList();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void TechnicalsDGV_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                id = int.Parse(TechnicalsDGV.CurrentRow.Cells[0].Value.ToString());
                tech = db.Technicals.SingleOrDefault(t => t.Id == id);
                if(tech == null)
                {
                    return;
                }
                txtName.Text = tech.Name;
            }
            catch  { }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل انت متأكد من تعديل هذا الفني", " تعديل الفني ", MessageBoxButtons.YesNo);
            if (db.Technicals.Where(t => t.Name == txtName.Text).Count() > 0)
            {
                MessageBox.Show("هذا الفني موجود بالفعل");
                return;
            }
            if(result == DialogResult.Yes)
            {
                id = int.Parse(TechnicalsDGV.CurrentRow.Cells[0].Value.ToString());
                tech = db.Technicals.SingleOrDefault(t => t.Id == id);

                tech.Name = txtName.Text;
                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");

                TechnicalsDGV.DataSource = db.Technicals.ToList();           
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل انت متأكد من حذف هذا الفني", " حذف هذا الفني ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var tech = db.Technicals.Find(id);
                db.Technicals.Remove(tech);
                db.SaveChanges();

                MessageBox.Show("تم الحذف بنجاح");
                TechnicalsDGV.DataSource = db.Technicals.ToList();
            }
        }
    }
}

using maintenanceCenter.Bills;
using maintenanceCenter.DB;
using maintenanceCenter.Utiltiy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenanceCenter.Screens.Bills
{
    public partial class DeviceReview : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();
        int id;
        Bill bill;
        public DeviceReview()
        {
            InitializeComponent();
            DeviceReviewDGV.DataSource = db.Bills.Where(b => b.Status == null).ToList();
        }

        private void DeviceReviewDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(DeviceReviewDGV.CurrentRow.Cells[0].Value.ToString());
                bill = db.Bills.SingleOrDefault(t => t.Id == id);
                if (bill == null)
                    return;
                txtBillNumber.Text = bill.Id.ToString();
                txtName.Text = bill.ClientName;
                txtPhone.Text = bill.ClientPhone;
                txtDeviceName.Text = bill.DeviceName;
                txtProblem.Text = bill.Problem;
                lblPaid.Text = bill.Paid.ToString();
                lblReset.Text = bill.TheRest.ToString();
                txtNotes.Text = bill.Notes;
                dateTimePicker1.Value = (DateTime)bill.DeliveryDate;
                comboBox1.SelectedValue = bill.Technical.Id;
            }
            catch { }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "")
                DeviceReviewDGV.DataSource = 
                    db.Bills.Where(b => b.Id.ToString().Contains(txtSearchBillId.Text) && b.Status == null).ToList();
            else if (txtSearchBillId.Text == "")
                DeviceReviewDGV.DataSource = 
                    db.Bills.Where(b => b.ClientName.Contains(txtSearchName.Text) && b.Status == null).ToList();
            else
                DeviceReviewDGV.DataSource = 
                    db.Bills.Where(b => (b.ClientName.Contains(txtSearchName.Text) || b.Id.ToString().Contains(txtSearchBillId.Text)) && b.Status == null).ToList();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            DeviceReviewDGV.DataSource = db.Bills.Where(b => b.Status == null).ToList();
            txtSearchName.Text = "";
            txtSearchBillId.Text = "";
        }

        private void addBillBtn_Click(object sender, EventArgs e)
        {
            AddBill frm = new AddBill();
            frm.Show();
            this.Close();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل تم تسليم الجهاز", " تم تسليم الجهاز ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                id = int.Parse(DeviceReviewDGV.CurrentRow.Cells[0].Value.ToString());
                bill = db.Bills.SingleOrDefault(t => t.Id == id);
                if (bill == null)
                    return;

                //bill.Notes = txtNotes.Text;
                bill.Status = SD.deviceAccepted;

                db.SaveChanges();
                MessageBox.Show("تم التسليم بنجاح");
                DeviceReviewDGV.DataSource = db.Bills.Where(b => b.Status == null).ToList();
            }
        }

        private void RefuseBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل تم رفض الجهاز", " تم رفض الجهاز ", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                id = int.Parse(DeviceReviewDGV.CurrentRow.Cells[0].Value.ToString());
                bill = db.Bills.SingleOrDefault(t => t.Id == id);
                if (bill == null)
                    return;

                bill.Status = SD.deviceRefused;

                db.SaveChanges();
                MessageBox.Show("تم رفض الجهاز");
                DeviceReviewDGV.DataSource = db.Bills.Where(b => b.Status == null).ToList();
            }
        }

        private void DeviceReview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceCenterDataSet.Technicals' table. You can move, or remove it, as needed.
            this.technicalsTableAdapter2.Fill(this.maintenanceCenterDataSet.Technicals);
            // TODO: This line of code loads data into the 'maintenanceCenterDataSet2.Technicals' table. You can move, or remove it, as needed.
            this.technicalsTableAdapter1.Fill(this.maintenanceCenterDataSet2.Technicals);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = false;
        }

        private void DeviceReviewDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

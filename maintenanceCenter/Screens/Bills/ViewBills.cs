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

namespace maintenanceCenter.Bills
{
    public partial class ViewBills : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();
        int id;
        Bill bill;
        public ViewBills()
        {

            InitializeComponent();
            BillsDGV.DataSource = db.Bills.ToList();
        }

        private void BillsDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(BillsDGV.CurrentRow.Cells[0].Value.ToString());
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
                //comboBox2.SelectedValue = bill.Technical1.Id;
            }
            catch { }
        }

        private void ViewBills_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceCenterDataSet1.Technicals' table. You can move, or remove it, as needed.
            this.technicalsTableAdapter.Fill(this.maintenanceCenterDataSet1.Technicals);

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل انت متأكد من تعديل هذه الفاتورة", " تم تعديل الفااتورة ", MessageBoxButtons.YesNo);
            if (txtName.Text == "" || txtPhone.Text == "" || txtDeviceName.Text == ""
                                   || txtProblem.Text == "" || lblPaid.Text == "" || lblReset.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات المطلوبة");
            }

            else if (result == DialogResult.Yes)
            {
                

                id = int.Parse(BillsDGV.CurrentRow.Cells[0].Value.ToString());
                bill = db.Bills.SingleOrDefault(t => t.Id == id);
                if (bill == null)
                    return;

                bill.ClientName = txtName.Text;
                bill.ClientPhone = txtPhone.Text;
                bill.DeviceName = txtDeviceName.Text;
                bill.Problem = txtProblem.Text;
                bill.Paid = decimal.Parse(lblPaid.Text);
                bill.TheRest = decimal.Parse(lblReset.Text);
                bill.Notes = txtNotes.Text;
                bill.DeliveryDate = dateTimePicker1.Value.Date;
                bill.TechnicalId = int.Parse(comboBox1.SelectedValue.ToString());

                db.SaveChanges();
                MessageBox.Show("تم التعديل بنجاح");
                BillsDGV.DataSource = db.Bills.ToList();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل انت متأكد من حذف هذه الفاتورة", " تم حذف هذه الفاتورة ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var bill = db.Bills.Find(id);
                db.Bills.Remove(bill);
                db.SaveChanges();

                MessageBox.Show("تم الحذف بنجاح");
                BillsDGV.DataSource = db.Bills.ToList();
            }
        }

        private void addBillBtn_Click(object sender, EventArgs e)
        {
            AddBill frm = new AddBill();
            frm.Show();
            this.Close();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "")
                BillsDGV.DataSource = db.Bills.Where(b => b.Id.ToString().Contains(txtSearchBillId.Text)).ToList();
            else if(txtSearchBillId.Text == "")
                BillsDGV.DataSource = db.Bills.Where(b => b.ClientName.Contains(txtSearchName.Text)).ToList();
            else
                BillsDGV.DataSource = db.Bills.Where(b => b.ClientName.Contains(txtSearchName.Text) || b.Id.ToString().Contains(txtSearchBillId.Text)).ToList();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            BillsDGV.DataSource = db.Bills.ToList();
            txtSearchName.Text = "";
            txtSearchBillId.Text = "";
        }

        private void BillsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

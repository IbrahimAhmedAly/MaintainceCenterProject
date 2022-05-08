using maintenanceCenter.Bills;
using maintenanceCenter.DB;
using maintenanceCenter.Utiltiy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenanceCenter.Screens.Bills_Calculation
{
    public partial class BillsCalculation : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();
        int id;
        Bill bill;
        public BillsCalculation()
        {
            InitializeComponent();
            BillsCalculationDGV.DataSource = db.Bills.Where(b => b.Status == SD.deviceAccepted).ToList();
            comboBox2.DataSource = db.Technicals.ToList();
        }

        private void BillsCalculationDGV_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(BillsCalculationDGV.CurrentRow.Cells[0].Value.ToString());
                bill = db.Bills.SingleOrDefault(t => t.Id == id);
                if (bill == null)
                    return;
                txtBillNumber.Text = bill.Id.ToString();
                txtName.Text = bill.ClientName;
                txtPhone.Text = bill.ClientPhone;
                txtDeviceName.Text = bill.DeviceName;
                txtProblem.Text = bill.Problem;
                textBox1.Text = (bill.Paid + bill.TheRest).ToString();
                txtNotes.Text = bill.Notes;
                dateTimePicker1.Value = (DateTime)bill.DeliveryDate;

                txtCost.Text = bill.Cost.ToString();
                txtNetProfit.Text = bill.NetProfit.ToString();
            }
            catch { }
        }

        private void BillsCalculation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceCenterDataSet.Technicals' table. You can move, or remove it, as needed.
            this.technicalsTableAdapter.Fill(this.maintenanceCenterDataSet.Technicals);

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
                BillsCalculationDGV.DataSource = db.Bills.Where(b => b.Id.ToString().Contains(txtSearchBillId.Text) && b.Status == SD.deviceAccepted).ToList();
            else if (txtSearchBillId.Text == "")
                BillsCalculationDGV.DataSource = db.Bills.Where(b => b.ClientName.Contains(txtSearchName.Text) && b.Status == SD.deviceAccepted).ToList();
            else
                BillsCalculationDGV.DataSource = db.Bills.Where(b => (b.ClientName.Contains(txtSearchName.Text) || b.Id.ToString().Contains(txtSearchBillId.Text)) && b.Status == SD.deviceAccepted).ToList();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            BillsCalculationDGV.DataSource = db.Bills.Where(b => b.Status == SD.deviceAccepted).ToList();
            txtSearchName.Text = "";
            txtSearchBillId.Text = "";
            txtBilsCount.Text = "";
            txtTotalCost.Text = "";
            txtTotalNetProfit.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" هل انت متأكد من التعديل", " سيتم التعديل ", MessageBoxButtons.YesNo);
            try
            {
                if (result == DialogResult.Yes)
                {
                    id = int.Parse(BillsCalculationDGV.CurrentRow.Cells[0].Value.ToString());
                    bill = db.Bills.SingleOrDefault(t => t.Id == id);
                    if (bill == null)
                        return;

                    bill.Cost = decimal.Parse(txtCost.Text);
                    bill.NetProfit = decimal.Parse(((bill.Paid + bill.TheRest) - bill.Cost).ToString());

                    db.SaveChanges();
                    MessageBox.Show("تم التعديل بنجاح");
                    BillsCalculationDGV.DataSource = db.Bills.Where(b => b.Status == SD.deviceAccepted).ToList();
                }
            }
            catch { }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int techId = int.Parse(comboBox2.SelectedValue.ToString());
            BillsCalculationDGV.DataSource = db.Bills.Where(b => b.TechnicalId == techId && b.Status == SD.deviceAccepted).ToList();
            txtBilsCount.Text = $"{BillsCalculationDGV.RowCount}";
            calculated();
        }
        SqlConnection Cn = new SqlConnection(@"data source = DESKTOP-H7NTH2S\SQLEXPRESS ; database = maintenanceCenter ; integrated security = True");
        private void loadBtn_Click(object sender, EventArgs e)
        {
            decimal total = 0 , totalNetProfit = 0;
            try
            {
                Cn.Open();
                using(DataTable dt = new DataTable("Bill"))
                {
                    using(SqlCommand cmd = new SqlCommand("SELECT * FROM Bill WHERE DeliveryDate BETWEEN @fromdate AND @todate AND Status = 'accepted' ", Cn))
                    {
                        cmd.Parameters.AddWithValue("@fromdate", dtFromDate.Value);
                        cmd.Parameters.AddWithValue("@todate", dtToDate.Value);
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                        sqlDataAdapter.Fill(dt);
                        BillsCalculationDGV.DataSource = dt;
                        txtBilsCount.Text = $"{BillsCalculationDGV.RowCount - 1}";

                        for (int i = 0; i < BillsCalculationDGV.RowCount - 1; i++)
                        {
                            total += decimal.Parse(BillsCalculationDGV.Rows[i].Cells["paid"].Value.ToString())
                                        + decimal.Parse(BillsCalculationDGV.Rows[i].Cells["TheRest"].Value.ToString());

                            totalNetProfit += decimal.Parse(BillsCalculationDGV.Rows[i].Cells["NetProfit"].Value.ToString());
                        }
                        txtTotalCost.Text = total.ToString();
                        txtTotalNetProfit.Text = totalNetProfit.ToString();
                    }
                }
                Cn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void calculated()
        {
            try
            {
                decimal totalCost = 0, totalNetProfit = 0;

                for (int i = 0; i < BillsCalculationDGV.RowCount; i++)
                {
                    totalCost += decimal.Parse(BillsCalculationDGV.Rows[i].Cells["paid"].Value.ToString())
                                    +decimal.Parse(BillsCalculationDGV.Rows[i].Cells["TheRest"].Value.ToString());

                    totalNetProfit += decimal.Parse(BillsCalculationDGV.Rows[i].Cells["NetProfit"].Value.ToString());
                }
                txtTotalCost.Text = totalCost.ToString();
                txtTotalNetProfit.Text = totalNetProfit.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNetProfit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {  
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush My_Color = new SolidBrush(Color.Black);
            Graphics MyGraphics = e.Graphics;
            Font MyFont0 = new Font("Arial", 12, FontStyle.Bold);
            String Hell = "____________________________________";
            int My_X = 0;
            int My_Y = 0;
            int My_newline = 0;

            StringFormat formt0 = new StringFormat();
            StringFormat formt3 = new StringFormat();

            formt3 = new StringFormat(StringFormatFlags.DirectionVertical);
            formt0 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
           
            My_newline = My_newline + 60;
            MyGraphics.DrawString("الكابتن", new Font("Arial", 23, FontStyle.Bold), My_Color, 95, My_Y + 12);
            
            My_newline = My_newline + 25;
            MyGraphics.DrawString("التاريخ:" + DateTime.Now.ToShortDateString(), MyFont0, My_Color, 75, My_Y + My_newline);
            My_newline = My_newline + 10;
            MyGraphics.DrawString(Hell, new Font("Arial", 10, FontStyle.Bold), My_Color, 0, My_Y + My_newline);
            My_newline = My_newline + 25;
            MyGraphics.DrawString("العطل", new Font("Rudaw", 10, FontStyle.Bold), My_Color, 280, My_Y + My_newline, formt0);
            MyGraphics.DrawString("التكلفة‌", new Font("Rudaw", 8, FontStyle.Bold), My_Color, My_X + 90, My_Y + My_newline);
            MyGraphics.DrawString("ثمنها", new Font("Rudaw", 8, FontStyle.Bold), My_Color, My_X + 58, My_Y + My_newline);
            MyGraphics.DrawString("صافي الربح", new Font("Rudaw", 8, FontStyle.Bold), My_Color, My_X + 2, My_Y + My_newline);

            My_newline = My_newline + 10;
            MyGraphics.DrawString("--------------------------------------------------------------", new Font("Arial", 10), My_Color, My_X, My_Y + My_newline);
            My_newline = My_newline + 25;

            StringFormat format1 = new StringFormat();
            format1 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            for (int i = 0; i < BillsCalculationDGV.Rows.Count - 1; i++)
            { 
                string problem = BillsCalculationDGV.Rows[i].Cells["Problem"].Value.ToString();
                decimal quantity = decimal.Parse(BillsCalculationDGV.Rows[i].Cells["paid"].Value.ToString())
                                    + decimal.Parse(BillsCalculationDGV.Rows[i].Cells["TheRest"].Value.ToString());
                string price = BillsCalculationDGV.Rows[i].Cells["Cost"].Value.ToString();
                string total = BillsCalculationDGV.Rows[i].Cells["NetProfit"].Value.ToString();
                price = String.Format("{0:n0}", double.Parse(price));
                total = String.Format("{0:n0}", double.Parse(total));

                MyGraphics.DrawString(problem, new Font("RudawRegular", 8), My_Color, 280, My_Y + My_newline, format1);
                MyGraphics.DrawString(price, new Font("RudawRegular", 8), My_Color, 55, My_Y + My_newline);
                MyGraphics.DrawString(quantity.ToString(), new Font("RudawRegular", 8), My_Color, 96, My_Y + My_newline);
                MyGraphics.DrawString(total, new Font("RudawRegular", 8), My_Color, 5, My_Y + My_newline);
                My_newline = My_newline + 8;
                MyGraphics.DrawString("--------------------------------------------------------------", new Font("Arial", 10), My_Color, My_X, My_Y + My_newline);
                My_newline = My_newline + 20;
            }
            MyGraphics.DrawString(txtBilsCount.Text, MyFont0, My_Color, 0, My_Y + My_newline);
            MyGraphics.DrawString("عدد الفواتير:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;
            MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, My_Y + My_newline);
            My_newline = My_newline + 20;
            MyGraphics.DrawString(txtTotalCost.Text, MyFont0, My_Color, 2, My_Y + My_newline);
            MyGraphics.DrawString("التكلفة:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;
            MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, My_Y + My_newline);
            My_newline = My_newline + 30;
            MyGraphics.DrawString(txtTotalNetProfit.Text, MyFont0, My_Color, 2, My_Y + My_newline);
            MyGraphics.DrawString("صافي الربح:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;
            MyGraphics.DrawString("***************************************************", new Font("Arial", 10), My_Color, 0, My_Y + My_newline);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.PrinterSettings.PrinterName = "XP-80C (copy 1)";
            printDocument1.Print();
        }
    }
}

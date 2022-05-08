using maintenanceCenter.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenanceCenter.Bills
{
    public partial class AddBill : Form
    {
        maintenanceCenterEntities db = new maintenanceCenterEntities();
        public AddBill()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddBill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'maintenanceCenterDataSet3.Technicals' table. You can move, or remove it, as needed.
            this.technicalsTableAdapter1.Fill(this.maintenanceCenterDataSet3.Technicals);
            // TODO: This line of code loads data into the 'maintenanceCenterDataSet.Technicals' table. You can move, or remove it, as needed.
            this.technicalsTableAdapter.Fill(this.maintenanceCenterDataSet.Technicals);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtDeviceName.Text == ""
                                   || txtProblem.Text == "" || lblPaid.Text == "" || lblReset.Text == "")
            {
                MessageBox.Show("برجاء ادخال البيانات المطلوبة");
            }
            else
            {
                Bill bill = new Bill
                {
                    ClientName = txtName.Text,
                    ClientPhone = txtPhone.Text,
                    DeviceName = txtDeviceName.Text,
                    Problem = txtProblem.Text,
                    Paid = decimal.Parse(lblPaid.Text),
                    TheRest = decimal.Parse(lblReset.Text),
                    Notes = txtNotes.Text,
                    TechnicalId = int.Parse(comboBox1.SelectedValue.ToString()),
                    Received = int.Parse(comboBox2.SelectedValue.ToString()),
                    DeliveryDate = dateTimePicker1.Value.Date,

                    Cost = 0,
                    NetProfit = 0
                };
                db.Bills.Add(bill);
                db.SaveChanges();
                txtBillNumber.Text = bill.Id.ToString();
                MessageBox.Show("تم حفظ الفاتورة");

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ViewBills frm = new ViewBills();
            frm.Show();
            this.Close();
        }

        private void ResetBtn_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtDeviceName.Text = "";
            txtProblem.Text = "";
            lblPaid.Text = "";
            lblReset.Text = "";
            txtNotes.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {

            printDocument1.PrinterSettings.PrinterName = "XP-80C (copy 1)";
            printDocument1.Print();

            printDocument2.PrinterSettings.PrinterName = "Xprinter XP-235B";
            printDocument2.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush My_Color = new SolidBrush(Color.Black);
            Graphics MyGraphics = e.Graphics;
            Font MyFont0 = new Font("Arial", 12, FontStyle.Bold);
            String Hell = "_____________________________________";
            int My_Y = 0;
            int My_newline = 0;

            MyGraphics.DrawString(txtBillNumber.Text, MyFont0, My_Color, 3, My_Y + My_newline);
            MyGraphics.DrawString("الكابتن", new Font("Arial", 23, FontStyle.Bold), My_Color, 95, My_Y + 12);

            //var desRect = new Rectangle(40, 40, 195, 80);

            My_newline = My_newline + 60;
            StringFormat formt0 = new StringFormat();
            StringFormat formt3 = new StringFormat();

            //formt3 = new StringFormat(StringFormatFlags.DirectionVertical);
            formt0 = new StringFormat(StringFormatFlags.DirectionRightToLeft);


            MyGraphics.DrawString("التاريخ:" + DateTime.Now.ToShortDateString(), MyFont0, My_Color, 75, My_Y + My_newline);
            My_newline = My_newline + 10;
            MyGraphics.DrawString(Hell, new Font("Arial", 10, FontStyle.Bold), My_Color, 0, My_Y + My_newline);
            My_newline = My_newline + 25;

            StringFormat format1 = new StringFormat();
            format1 = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            MyGraphics.DrawString(txtName.Text, MyFont0, My_Color, 140, My_Y + My_newline);
            MyGraphics.DrawString("اسم العميل:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 20;
            MyGraphics.DrawString(txtDeviceName.Text, MyFont0, My_Color, 140, My_Y + My_newline);
            MyGraphics.DrawString("موديل الجهاز:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 30;
            MyGraphics.DrawString(txtProblem.Text, MyFont0, My_Color, 140, My_Y + My_newline);
            MyGraphics.DrawString("العطل:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 20;
            MyGraphics.DrawString(lblPaid.Text, MyFont0, My_Color, 170, My_Y + My_newline);
            MyGraphics.DrawString("المدفوع:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            MyGraphics.DrawString(lblReset.Text, MyFont0, My_Color, 70, My_Y + My_newline);
            MyGraphics.DrawString("الباقي:", MyFont0, My_Color, 150, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 20;
            MyGraphics.DrawString(dateTimePicker1.Text, MyFont0, My_Color, 2, My_Y + My_newline);
            MyGraphics.DrawString("تاريخ التسليم:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 20;
            MyGraphics.DrawString(comboBox2.Text, MyFont0, My_Color, 160, My_Y + My_newline);
            MyGraphics.DrawString("المستلم:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            MyGraphics.DrawString(comboBox1.Text, MyFont0, My_Color, 30, My_Y + My_newline);
            MyGraphics.DrawString("الفني:", MyFont0, My_Color, 150, My_Y + My_newline, formt0);
            My_newline = My_newline + 18;
            MyGraphics.DrawString("_____________________________________", new Font("Arial", 10), My_Color, 0, My_Y + My_newline);
            My_newline = My_newline + 30;

            //MyGraphics.DrawString("_____________________________________", new Font("Arial", 10), My_Color, 0, My_Y + My_newline);
            MyGraphics.DrawString("شروط التسليم:", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 30;
            MyGraphics.DrawString("1- الاستلام بدون متعلقات ", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("2- المركز غير مسئول عن اي عطل غير متفق عليه", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("3- لاتغادر مركز الصيانة بدون ايصال ومتعلقات ", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("الجهاز", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("4- الشاشة اللحام والصيني ليس لها ضمان", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("5- عدم ضمان الشاشة الاخري ثلاث ايام فقط ", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString(" بشرط الكسر او نزع الا ستيكر", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("6- في حالة فقدان الايصال يمضي العميل علي", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("اقرار استلام الجهاز", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString("7- اقصي مدة لترك الجهاز هي شهر واحد وبعد", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;
            MyGraphics.DrawString(" ذلك يتم اعتبارة هالك", MyFont0, My_Color, 280, My_Y + My_newline, formt0);
            My_newline = My_newline + 22;

            MyGraphics.DrawString("_____________________________________", new Font("Arial", 10), My_Color, 0, My_Y + My_newline);
            My_newline = My_newline + 30;

            MyGraphics.DrawString("التاريخ:" + DateTime.Now.ToShortDateString(), MyFont0, My_Color, 75, My_Y + My_newline);
            My_newline = My_newline + 10;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            printDocument2.PrinterSettings.PrinterName = "Xprinter XP-235B";
            printDocument2.Print();
        }
        private void printDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush My_Color = new SolidBrush(Color.Black);
            Graphics MyGraphics = e.Graphics;
            Font MyFont0 = new Font("Arial", 12, FontStyle.Bold);
            int My_newline = 0;

            My_newline = My_newline + 60;
            StringFormat formt0 = new StringFormat();
            StringFormat formt3 = new StringFormat();

            formt0 = new StringFormat(StringFormatFlags.DirectionRightToLeft);

            My_newline = My_newline + 20;
            MyGraphics.DrawString(txtBillNumber.Text, MyFont0, My_Color, 90, -60 + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 30;
            MyGraphics.DrawString(txtProblem.Text, MyFont0, My_Color, 20, -90 + My_newline);
            My_newline = My_newline + 18;

            My_newline = My_newline + 30;
            MyGraphics.DrawString(dateTimePicker1.Text, new Font("Arial", 12, FontStyle.Bold), My_Color, 190, -120 + My_newline, formt0);
            My_newline = My_newline + 18;

            My_newline = My_newline + 30;
            MyGraphics.DrawString("ف:", MyFont0, My_Color, 190, -150 + My_newline, formt0);
            MyGraphics.DrawString(comboBox1.Text, MyFont0, My_Color, 170, -150 + My_newline, formt0);

            MyGraphics.DrawString("م:", MyFont0, My_Color, 80, -150 + My_newline, formt0);
            MyGraphics.DrawString(comboBox2.Text, MyFont0, My_Color, 60, -150 + My_newline, formt0);
            My_newline = My_newline + 18;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

using maintenanceCenter.Bills;
using maintenanceCenter.Screens.Bills;
using maintenanceCenter.Screens.Bills_Calculation;
using maintenanceCenter.Screens.NewUser;
using maintenanceCenter.Screens.Technicals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maintenanceCenter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string userName, password;
        public MainForm(string user , string pass)
        {
            InitializeComponent();
            userName = user;
            password = pass;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            if(userName == "Admin" && password == "admincap") 
            {
                calculationBtn.Enabled = true;
            }
            else
            {
                calculationBtn.Enabled = false;
            }
        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUser frm = new NewUser();
            frm.Show();
        }

        private void addNewTechnicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTechnical frm = new AddTechnical();
            frm.Show();
        }

        private void viewAllTechnicalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewTechniclas frm = new ViewTechniclas();
            frm.Show();
        }

        private void addBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBill frm = new AddBill();
            frm.Show();
        }

        private void viewBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBills frm = new ViewBills();
            frm.Show();
        }

        private void مراجعةالجهازقبلالتسليمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceReview frm = new DeviceReview();
            frm.Show();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RefuseBtn_Click(object sender, EventArgs e)
        {
            AddBill frm = new AddBill();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewBills frm = new ViewBills();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DeviceReview frm = new DeviceReview();
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BillsCalculation frm = new BillsCalculation();
            frm.Show();
        }
    }
}

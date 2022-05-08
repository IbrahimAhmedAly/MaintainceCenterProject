
namespace maintenanceCenter.Screens.Bills_Calculation
{
    partial class BillsCalculation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.addBillBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearchBillId = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.BillsCalculationDGV = new System.Windows.Forms.DataGridView();
            this.technicalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceCenterDataSet = new maintenanceCenter.maintenanceCenterDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.technicalsTableAdapter = new maintenanceCenter.maintenanceCenterDataSetTableAdapters.TechnicalsTableAdapter();
            this.txtNetProfit = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBilsCount = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtTotalNetProfit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillsCalculationDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Enabled = false;
            this.txtBillNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNumber.Location = new System.Drawing.Point(881, 7);
            this.txtBillNumber.Multiline = true;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.ReadOnly = true;
            this.txtBillNumber.Size = new System.Drawing.Size(99, 33);
            this.txtBillNumber.TabIndex = 123;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(986, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 24);
            this.label20.TabIndex = 122;
            this.label20.Text = "رقم الفاتورة";
            // 
            // addBillBtn
            // 
            this.addBillBtn.BackColor = System.Drawing.Color.White;
            this.addBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBillBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBillBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addBillBtn.Location = new System.Drawing.Point(796, 444);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Size = new System.Drawing.Size(165, 41);
            this.addBillBtn.TabIndex = 121;
            this.addBillBtn.Text = "اضافة الفاتورة";
            this.addBillBtn.UseVisualStyleBackColor = false;
            this.addBillBtn.Click += new System.EventHandler(this.addBillBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.RefreshBtn.Location = new System.Drawing.Point(305, 52);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(90, 38);
            this.RefreshBtn.TabIndex = 120;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.White;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SearchBtn.Location = new System.Drawing.Point(411, 52);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(97, 38);
            this.SearchBtn.TabIndex = 119;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtSearchBillId
            // 
            this.txtSearchBillId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBillId.Location = new System.Drawing.Point(1031, 394);
            this.txtSearchBillId.Multiline = true;
            this.txtSearchBillId.Name = "txtSearchBillId";
            this.txtSearchBillId.Size = new System.Drawing.Size(200, 28);
            this.txtSearchBillId.TabIndex = 118;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(1031, 346);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(200, 28);
            this.txtSearchName.TabIndex = 117;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1245, 392);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 30);
            this.label19.TabIndex = 116;
            this.label19.Text = "رقم الفاتورة";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1256, 344);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 30);
            this.label18.TabIndex = 115;
            this.label18.Text = "اسم العميل";
            // 
            // BillsCalculationDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.BillsCalculationDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.BillsCalculationDGV.BackgroundColor = System.Drawing.Color.White;
            this.BillsCalculationDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillsCalculationDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.BillsCalculationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillsCalculationDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.BillsCalculationDGV.Location = new System.Drawing.Point(13, 130);
            this.BillsCalculationDGV.Name = "BillsCalculationDGV";
            this.BillsCalculationDGV.ReadOnly = true;
            this.BillsCalculationDGV.Size = new System.Drawing.Size(558, 330);
            this.BillsCalculationDGV.TabIndex = 114;
            this.BillsCalculationDGV.SelectionChanged += new System.EventHandler(this.BillsCalculationDGV_SelectionChanged);
            // 
            // technicalsBindingSource
            // 
            this.technicalsBindingSource.DataMember = "Technicals";
            this.technicalsBindingSource.DataSource = this.maintenanceCenterDataSet;
            // 
            // maintenanceCenterDataSet
            // 
            this.maintenanceCenterDataSet.DataSetName = "maintenanceCenterDataSet";
            this.maintenanceCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(1031, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 112;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(1038, 123);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(203, 28);
            this.txtPhone.TabIndex = 111;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(1038, 66);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(203, 28);
            this.txtName.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1256, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 109;
            this.label4.Text = "تليفون العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1276, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 108;
            this.label3.Text = "اسم العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1113, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 107;
            this.label2.Text = "-------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1120, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "بيانات العميل";
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.Location = new System.Drawing.Point(981, 444);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(167, 41);
            this.EditBtn.TabIndex = 104;
            this.EditBtn.Text = "حفظ التعديل";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1255, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 30);
            this.label17.TabIndex = 102;
            this.label17.Text = "ميعاد التسليم";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1106, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 101;
            this.label14.Text = "-------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1113, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 24);
            this.label15.TabIndex = 100;
            this.label15.Text = "بيانات التسليم";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(610, 227);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(203, 94);
            this.txtNotes.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(876, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 30);
            this.label9.TabIndex = 93;
            this.label9.Text = "ملاحظات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(904, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 30);
            this.label10.TabIndex = 92;
            this.label10.Text = "التكلفة";
            // 
            // txtProblem
            // 
            this.txtProblem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblem.Location = new System.Drawing.Point(610, 123);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.ReadOnly = true;
            this.txtProblem.Size = new System.Drawing.Size(203, 28);
            this.txtProblem.TabIndex = 91;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(610, 66);
            this.txtDeviceName.Multiline = true;
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.ReadOnly = true;
            this.txtDeviceName.Size = new System.Drawing.Size(203, 28);
            this.txtDeviceName.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(904, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 89;
            this.label7.Text = "العطل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(848, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 88;
            this.label8.Text = "موديل الجهاز";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "-------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 86;
            this.label6.Text = "بيانات الجهاز";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.technicalsBindingSource;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(305, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 32);
            this.comboBox2.TabIndex = 125;
            this.comboBox2.ValueMember = "Id";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(519, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 30);
            this.label21.TabIndex = 124;
            this.label21.Text = "الفني";
            // 
            // technicalsTableAdapter
            // 
            this.technicalsTableAdapter.ClearBeforeFill = true;
            // 
            // txtNetProfit
            // 
            this.txtNetProfit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetProfit.Location = new System.Drawing.Point(610, 405);
            this.txtNetProfit.Multiline = true;
            this.txtNetProfit.Name = "txtNetProfit";
            this.txtNetProfit.ReadOnly = true;
            this.txtNetProfit.Size = new System.Drawing.Size(203, 28);
            this.txtNetProfit.TabIndex = 131;
            this.txtNetProfit.Text = "0";
            this.txtNetProfit.TextChanged += new System.EventHandler(this.txtNetProfit_TextChanged);
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(610, 362);
            this.txtCost.Multiline = true;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(203, 28);
            this.txtCost.TabIndex = 130;
            this.txtCost.Text = "0";
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(828, 403);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(106, 30);
            this.label24.TabIndex = 129;
            this.label24.Text = "صافي الربح";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(848, 362);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 30);
            this.label25.TabIndex = 128;
            this.label25.Text = "ثمنها";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(577, 324);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(353, 24);
            this.label22.TabIndex = 132;
            this.label22.Text = "-------------------------------------------------";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(610, 172);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(203, 28);
            this.textBox1.TabIndex = 133;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 30);
            this.label11.TabIndex = 134;
            this.label11.Text = ":من";
            // 
            // dtFromDate
            // 
            this.dtFromDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(13, 14);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(200, 26);
            this.dtFromDate.TabIndex = 135;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(219, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 30);
            this.label12.TabIndex = 136;
            this.label12.Text = ":الي";
            // 
            // dtToDate
            // 
            this.dtToDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(13, 54);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 26);
            this.dtToDate.TabIndex = 137;
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.White;
            this.loadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loadBtn.Location = new System.Drawing.Point(16, 86);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(120, 38);
            this.loadBtn.TabIndex = 138;
            this.loadBtn.Text = "تحميل";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(553, 465);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 30);
            this.label16.TabIndex = 139;
            this.label16.Text = "عدد الفواتير";
            // 
            // txtBilsCount
            // 
            this.txtBilsCount.Enabled = false;
            this.txtBilsCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilsCount.Location = new System.Drawing.Point(440, 468);
            this.txtBilsCount.Multiline = true;
            this.txtBilsCount.Name = "txtBilsCount";
            this.txtBilsCount.Size = new System.Drawing.Size(111, 28);
            this.txtBilsCount.TabIndex = 140;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCost.Location = new System.Drawing.Point(254, 467);
            this.txtTotalCost.Multiline = true;
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(113, 28);
            this.txtTotalCost.TabIndex = 143;
            this.txtTotalCost.TextChanged += new System.EventHandler(this.txtTotalCost_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(373, 467);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(58, 30);
            this.label26.TabIndex = 141;
            this.label26.Text = "التكلفة";
            // 
            // txtTotalNetProfit
            // 
            this.txtTotalNetProfit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNetProfit.Location = new System.Drawing.Point(23, 466);
            this.txtTotalNetProfit.Multiline = true;
            this.txtTotalNetProfit.Name = "txtTotalNetProfit";
            this.txtTotalNetProfit.ReadOnly = true;
            this.txtTotalNetProfit.Size = new System.Drawing.Size(113, 28);
            this.txtTotalNetProfit.TabIndex = 145;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(142, 464);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 30);
            this.label13.TabIndex = 146;
            this.label13.Text = "صافي الربح";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printReportBtn
            // 
            this.printReportBtn.BackColor = System.Drawing.Color.White;
            this.printReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printReportBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReportBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.printReportBtn.Location = new System.Drawing.Point(147, 86);
            this.printReportBtn.Name = "printReportBtn";
            this.printReportBtn.Size = new System.Drawing.Size(120, 38);
            this.printReportBtn.TabIndex = 147;
            this.printReportBtn.Text = "طباعة التقرير";
            this.printReportBtn.UseVisualStyleBackColor = false;
            this.printReportBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillsCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 508);
            this.Controls.Add(this.printReportBtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalNetProfit);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtBilsCount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtNetProfit);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.addBillBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.txtSearchBillId);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BillsCalculationDGV);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.Name = "BillsCalculation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillsCalculation";
            this.Load += new System.EventHandler(this.BillsCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillsCalculationDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button addBillBtn;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearchBillId;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView BillsCalculationDGV;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label21;
        private maintenanceCenterDataSet maintenanceCenterDataSet;
        private System.Windows.Forms.BindingSource technicalsBindingSource;
        private maintenanceCenterDataSetTableAdapters.TechnicalsTableAdapter technicalsTableAdapter;
        private System.Windows.Forms.TextBox txtNetProfit;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBilsCount;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtTotalNetProfit;
        private System.Windows.Forms.Label label13;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button printReportBtn;
    }
}
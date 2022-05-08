
namespace maintenanceCenter.Screens.Bills
{
    partial class DeviceReview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBillNumber = new System.Windows.Forms.TextBox();
            this.addBillBtn = new System.Windows.Forms.Button();
            this.technicalsTableAdapter = new maintenanceCenter.maintenanceCenterDataSet1TableAdapters.TechnicalsTableAdapter();
            this.label20 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.txtSearchBillId = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.DeviceReviewDGV = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.technicalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceCenterDataSet1 = new maintenanceCenter.maintenanceCenterDataSet1();
            this.technicalsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceCenterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maintenanceCenterDataSet = new maintenanceCenter.maintenanceCenterDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblPaid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProblem = new System.Windows.Forms.TextBox();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.RefuseBtn = new System.Windows.Forms.Button();
            this.maintenanceCenterDataSet2 = new maintenanceCenter.maintenanceCenterDataSet2();
            this.technicalsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.technicalsTableAdapter1 = new maintenanceCenter.maintenanceCenterDataSet2TableAdapters.TechnicalsTableAdapter();
            this.maintenanceCenterDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.technicalsTableAdapter2 = new maintenanceCenter.maintenanceCenterDataSetTableAdapters.TechnicalsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceReviewDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Enabled = false;
            this.txtBillNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNumber.Location = new System.Drawing.Point(795, 7);
            this.txtBillNumber.Multiline = true;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(99, 33);
            this.txtBillNumber.TabIndex = 123;
            // 
            // addBillBtn
            // 
            this.addBillBtn.BackColor = System.Drawing.Color.White;
            this.addBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBillBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBillBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addBillBtn.Location = new System.Drawing.Point(601, 405);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Size = new System.Drawing.Size(124, 41);
            this.addBillBtn.TabIndex = 121;
            this.addBillBtn.Text = "اضافة فاتورة";
            this.addBillBtn.UseVisualStyleBackColor = false;
            this.addBillBtn.Click += new System.EventHandler(this.addBillBtn_Click);
            // 
            // technicalsTableAdapter
            // 
            this.technicalsTableAdapter.ClearBeforeFill = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(900, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 24);
            this.label20.TabIndex = 122;
            this.label20.Text = "رقم الفاتورة";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.White;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.RefreshBtn.Location = new System.Drawing.Point(46, 63);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(90, 28);
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
            this.SearchBtn.Location = new System.Drawing.Point(46, 19);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(90, 28);
            this.SearchBtn.TabIndex = 119;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // txtSearchBillId
            // 
            this.txtSearchBillId.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBillId.Location = new System.Drawing.Point(190, 63);
            this.txtSearchBillId.Multiline = true;
            this.txtSearchBillId.Name = "txtSearchBillId";
            this.txtSearchBillId.Size = new System.Drawing.Size(169, 28);
            this.txtSearchBillId.TabIndex = 118;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(190, 17);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(169, 28);
            this.txtSearchName.TabIndex = 117;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(375, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 30);
            this.label19.TabIndex = 116;
            this.label19.Text = "رقم الفاتورة";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(385, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 30);
            this.label18.TabIndex = 115;
            this.label18.Text = "اسم العميل";
            // 
            // DeviceReviewDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.DeviceReviewDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeviceReviewDGV.BackgroundColor = System.Drawing.Color.White;
            this.DeviceReviewDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeviceReviewDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeviceReviewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeviceReviewDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeviceReviewDGV.Location = new System.Drawing.Point(13, 94);
            this.DeviceReviewDGV.Name = "DeviceReviewDGV";
            this.DeviceReviewDGV.ReadOnly = true;
            this.DeviceReviewDGV.Size = new System.Drawing.Size(473, 407);
            this.DeviceReviewDGV.TabIndex = 114;
            this.DeviceReviewDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeviceReviewDGV_CellContentClick);
            this.DeviceReviewDGV.SelectionChanged += new System.EventHandler(this.DeviceReviewDGV_SelectionChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.technicalsBindingSource, "Id", true));
            this.comboBox1.DataSource = this.technicalsBindingSource2;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(945, 350);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 32);
            this.comboBox1.TabIndex = 113;
            this.comboBox1.ValueMember = "Id";
            // 
            // technicalsBindingSource
            // 
            this.technicalsBindingSource.DataMember = "Technicals";
            this.technicalsBindingSource.DataSource = this.maintenanceCenterDataSet1;
            // 
            // maintenanceCenterDataSet1
            // 
            this.maintenanceCenterDataSet1.DataSetName = "maintenanceCenterDataSet1";
            this.maintenanceCenterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicalsBindingSource2
            // 
            this.technicalsBindingSource2.DataMember = "Technicals";
            this.technicalsBindingSource2.DataSource = this.maintenanceCenterDataSetBindingSource;
            // 
            // maintenanceCenterDataSetBindingSource
            // 
            this.maintenanceCenterDataSetBindingSource.DataSource = this.maintenanceCenterDataSet;
            this.maintenanceCenterDataSetBindingSource.Position = 0;
            // 
            // maintenanceCenterDataSet
            // 
            this.maintenanceCenterDataSet.DataSetName = "maintenanceCenterDataSet";
            this.maintenanceCenterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(945, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 112;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(952, 123);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(203, 28);
            this.txtPhone.TabIndex = 111;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(952, 66);
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
            this.label4.Location = new System.Drawing.Point(1170, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 109;
            this.label4.Text = "تليفون العميل";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1190, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 108;
            this.label3.Text = "اسم العميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1034, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 106;
            this.label1.Text = "بيانات العميل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1027, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 107;
            this.label2.Text = "-------------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1225, 348);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 30);
            this.label16.TabIndex = 103;
            this.label16.Text = "الفني";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1169, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 30);
            this.label17.TabIndex = 102;
            this.label17.Text = "ميعاد التسليم";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1020, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 24);
            this.label14.TabIndex = 101;
            this.label14.Text = "-------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1027, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 24);
            this.label15.TabIndex = 100;
            this.label15.Text = "بيانات التسليم";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(803, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 30);
            this.label13.TabIndex = 99;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(733, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 30);
            this.label12.TabIndex = 98;
            this.label12.Text = "مدفوع";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(580, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 30);
            this.label11.TabIndex = 97;
            this.label11.Text = "الباقي";
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(491, 170);
            this.lblReset.Multiline = true;
            this.lblReset.Name = "lblReset";
            this.lblReset.ReadOnly = true;
            this.lblReset.Size = new System.Drawing.Size(81, 28);
            this.lblReset.TabIndex = 96;
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(524, 227);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(203, 94);
            this.txtNotes.TabIndex = 95;
            // 
            // lblPaid
            // 
            this.lblPaid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.Location = new System.Drawing.Point(641, 170);
            this.lblPaid.Multiline = true;
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.ReadOnly = true;
            this.lblPaid.Size = new System.Drawing.Size(86, 29);
            this.lblPaid.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(790, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 30);
            this.label9.TabIndex = 93;
            this.label9.Text = "ملاحظات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(818, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 30);
            this.label10.TabIndex = 92;
            this.label10.Text = "التكلفة";
            // 
            // txtProblem
            // 
            this.txtProblem.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProblem.Location = new System.Drawing.Point(524, 123);
            this.txtProblem.Multiline = true;
            this.txtProblem.Name = "txtProblem";
            this.txtProblem.ReadOnly = true;
            this.txtProblem.Size = new System.Drawing.Size(203, 28);
            this.txtProblem.TabIndex = 91;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceName.Location = new System.Drawing.Point(524, 66);
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
            this.label7.Location = new System.Drawing.Point(818, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 30);
            this.label7.TabIndex = 89;
            this.label7.Text = "العطل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(762, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 88;
            this.label8.Text = "موديل الجهاز";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(593, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 87;
            this.label5.Text = "-------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(597, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 86;
            this.label6.Text = "بيانات الجهاز";
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.BackColor = System.Drawing.Color.White;
            this.AcceptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcceptBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AcceptBtn.Location = new System.Drawing.Point(524, 341);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(124, 41);
            this.AcceptBtn.TabIndex = 124;
            this.AcceptBtn.Text = "تم";
            this.AcceptBtn.UseVisualStyleBackColor = false;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // RefuseBtn
            // 
            this.RefuseBtn.BackColor = System.Drawing.Color.White;
            this.RefuseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefuseBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefuseBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.RefuseBtn.Location = new System.Drawing.Point(668, 341);
            this.RefuseBtn.Name = "RefuseBtn";
            this.RefuseBtn.Size = new System.Drawing.Size(124, 41);
            this.RefuseBtn.TabIndex = 125;
            this.RefuseBtn.Text = "رفض";
            this.RefuseBtn.UseVisualStyleBackColor = false;
            this.RefuseBtn.Click += new System.EventHandler(this.RefuseBtn_Click);
            // 
            // maintenanceCenterDataSet2
            // 
            this.maintenanceCenterDataSet2.DataSetName = "maintenanceCenterDataSet2";
            this.maintenanceCenterDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // technicalsBindingSource1
            // 
            this.technicalsBindingSource1.DataMember = "Technicals";
            this.technicalsBindingSource1.DataSource = this.maintenanceCenterDataSet2;
            // 
            // technicalsTableAdapter1
            // 
            this.technicalsTableAdapter1.ClearBeforeFill = true;
            // 
            // maintenanceCenterDataSetBindingSource1
            // 
            this.maintenanceCenterDataSetBindingSource1.DataSource = this.maintenanceCenterDataSet;
            this.maintenanceCenterDataSetBindingSource1.Position = 0;
            // 
            // technicalsTableAdapter2
            // 
            this.technicalsTableAdapter2.ClearBeforeFill = true;
            // 
            // DeviceReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1294, 508);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.RefuseBtn);
            this.Controls.Add(this.txtBillNumber);
            this.Controls.Add(this.addBillBtn);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.txtSearchBillId);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DeviceReviewDGV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProblem);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "DeviceReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسليم الجهاز";
            this.Load += new System.EventHandler(this.DeviceReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeviceReviewDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technicalsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceCenterDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBillNumber;
        private System.Windows.Forms.Button addBillBtn;
        private maintenanceCenterDataSet1TableAdapters.TechnicalsTableAdapter technicalsTableAdapter;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox txtSearchBillId;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView DeviceReviewDGV;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource technicalsBindingSource;
        private maintenanceCenterDataSet1 maintenanceCenterDataSet1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox lblReset;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox lblPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProblem;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.Button RefuseBtn;
        private maintenanceCenterDataSet2 maintenanceCenterDataSet2;
        private System.Windows.Forms.BindingSource technicalsBindingSource1;
        private maintenanceCenterDataSet2TableAdapters.TechnicalsTableAdapter technicalsTableAdapter1;
        private maintenanceCenterDataSet maintenanceCenterDataSet;
        private System.Windows.Forms.BindingSource maintenanceCenterDataSetBindingSource;
        private System.Windows.Forms.BindingSource maintenanceCenterDataSetBindingSource1;
        private System.Windows.Forms.BindingSource technicalsBindingSource2;
        private maintenanceCenterDataSetTableAdapters.TechnicalsTableAdapter technicalsTableAdapter2;
    }
}
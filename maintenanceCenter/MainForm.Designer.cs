
namespace maintenanceCenter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTechnicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllTechnicalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تسليمالجهازToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceReviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addBillBtn = new System.Windows.Forms.Button();
            this.viewBillsBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.calculationBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.technToolStripMenuItem,
            this.billsToolStripMenuItem,
            this.تسليمالجهازToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fileToolStripMenuItem.Text = "الملف";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.closeToolStripMenuItem.Text = "اغلاق البرنامج";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.usersToolStripMenuItem.Text = "المستخدمين";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewUserToolStripMenuItem.Text = "اضافة مستخدم جديد";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewToolStripMenuItem.Text = "View all users";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // technToolStripMenuItem
            // 
            this.technToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTechnicalToolStripMenuItem,
            this.viewAllTechnicalsToolStripMenuItem});
            this.technToolStripMenuItem.Name = "technToolStripMenuItem";
            this.technToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.technToolStripMenuItem.Text = "الفني";
            // 
            // addNewTechnicalToolStripMenuItem
            // 
            this.addNewTechnicalToolStripMenuItem.Name = "addNewTechnicalToolStripMenuItem";
            this.addNewTechnicalToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.addNewTechnicalToolStripMenuItem.Text = "اضافة فني";
            this.addNewTechnicalToolStripMenuItem.Click += new System.EventHandler(this.addNewTechnicalToolStripMenuItem_Click);
            // 
            // viewAllTechnicalsToolStripMenuItem
            // 
            this.viewAllTechnicalsToolStripMenuItem.Name = "viewAllTechnicalsToolStripMenuItem";
            this.viewAllTechnicalsToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.viewAllTechnicalsToolStripMenuItem.Text = "عرض جميع الفنيين";
            this.viewAllTechnicalsToolStripMenuItem.Click += new System.EventHandler(this.viewAllTechnicalsToolStripMenuItem_Click);
            // 
            // billsToolStripMenuItem
            // 
            this.billsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBillToolStripMenuItem,
            this.viewBillsToolStripMenuItem});
            this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
            this.billsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.billsToolStripMenuItem.Text = "الفواتير";
            this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
            // 
            // addBillToolStripMenuItem
            // 
            this.addBillToolStripMenuItem.Name = "addBillToolStripMenuItem";
            this.addBillToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addBillToolStripMenuItem.Text = "اضافة فاتورة";
            this.addBillToolStripMenuItem.Click += new System.EventHandler(this.addBillToolStripMenuItem_Click);
            // 
            // viewBillsToolStripMenuItem
            // 
            this.viewBillsToolStripMenuItem.Name = "viewBillsToolStripMenuItem";
            this.viewBillsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.viewBillsToolStripMenuItem.Text = "عرض جميع الفواتير";
            this.viewBillsToolStripMenuItem.Click += new System.EventHandler(this.viewBillsToolStripMenuItem_Click);
            // 
            // تسليمالجهازToolStripMenuItem
            // 
            this.تسليمالجهازToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeviceReviewToolStripMenuItem});
            this.تسليمالجهازToolStripMenuItem.Name = "تسليمالجهازToolStripMenuItem";
            this.تسليمالجهازToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.تسليمالجهازToolStripMenuItem.Text = "تسليم الجهاز";
            // 
            // DeviceReviewToolStripMenuItem
            // 
            this.DeviceReviewToolStripMenuItem.Name = "DeviceReviewToolStripMenuItem";
            this.DeviceReviewToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.DeviceReviewToolStripMenuItem.Text = "مراجعة الجهاز قبل التسليم";
            this.DeviceReviewToolStripMenuItem.Click += new System.EventHandler(this.مراجعةالجهازقبلالتسليمToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(29, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // addBillBtn
            // 
            this.addBillBtn.BackColor = System.Drawing.Color.White;
            this.addBillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBillBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBillBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addBillBtn.Location = new System.Drawing.Point(71, 257);
            this.addBillBtn.Name = "addBillBtn";
            this.addBillBtn.Size = new System.Drawing.Size(135, 41);
            this.addBillBtn.TabIndex = 126;
            this.addBillBtn.Text = "اضافة فاتورة";
            this.addBillBtn.UseVisualStyleBackColor = false;
            this.addBillBtn.Click += new System.EventHandler(this.RefuseBtn_Click);
            // 
            // viewBillsBtn
            // 
            this.viewBillsBtn.BackColor = System.Drawing.Color.White;
            this.viewBillsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBillsBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBillsBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.viewBillsBtn.Location = new System.Drawing.Point(419, 257);
            this.viewBillsBtn.Name = "viewBillsBtn";
            this.viewBillsBtn.Size = new System.Drawing.Size(178, 41);
            this.viewBillsBtn.TabIndex = 128;
            this.viewBillsBtn.Text = "عرض جميع الفواتير";
            this.viewBillsBtn.UseVisualStyleBackColor = false;
            this.viewBillsBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(385, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(233, 155);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 127;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(29, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 130;
            this.button1.Text = "مراجعة الجهاز قبل التسليم";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 327);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(233, 157);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 129;
            this.pictureBox4.TabStop = false;
            // 
            // calculationBtn
            // 
            this.calculationBtn.BackColor = System.Drawing.Color.White;
            this.calculationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculationBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.calculationBtn.Location = new System.Drawing.Point(419, 490);
            this.calculationBtn.Name = "calculationBtn";
            this.calculationBtn.Size = new System.Drawing.Size(178, 41);
            this.calculationBtn.TabIndex = 132;
            this.calculationBtn.Text = "الحسابات";
            this.calculationBtn.UseVisualStyleBackColor = false;
            this.calculationBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(385, 327);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(233, 157);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 131;
            this.pictureBox5.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exitBtn.Location = new System.Drawing.Point(553, 27);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(135, 41);
            this.exitBtn.TabIndex = 133;
            this.exitBtn.Text = "اغلاق البرنامج";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 548);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculationBtn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.viewBillsBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.addBillBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTechnicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllTechnicalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تسليمالجهازToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeviceReviewToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addBillBtn;
        private System.Windows.Forms.Button viewBillsBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button calculationBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button exitBtn;
    }
}
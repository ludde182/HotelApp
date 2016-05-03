namespace HotelApp
{
    partial class Form1
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
            this.cPnr_input = new System.Windows.Forms.TextBox();
            this.cPnr_lbl = new System.Windows.Forms.Label();
            this.cName_lbl = new System.Windows.Forms.Label();
            this.cName_input = new System.Windows.Forms.TextBox();
            this.cMail_lbl = new System.Windows.Forms.Label();
            this.cMail_input = new System.Windows.Forms.TextBox();
            this.createCust_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resCabin_comboBox = new System.Windows.Forms.ComboBox();
            this.resCabin_lbl = new System.Windows.Forms.Label();
            this.resWeek_lbl = new System.Windows.Forms.Label();
            this.resWeek_input = new System.Windows.Forms.NumericUpDown();
            this.checkAvail_btn = new System.Windows.Forms.Button();
            this.resCust_input = new System.Windows.Forms.TextBox();
            this.resCust_lbl = new System.Windows.Forms.Label();
            this.getCustByID_btn = new System.Windows.Forms.Button();
            this.findCust_input = new System.Windows.Forms.TextBox();
            this.getResByID_btn = new System.Windows.Forms.Button();
            this.findcPnr_lbl = new System.Windows.Forms.Label();
            this.findRes_input = new System.Windows.Forms.TextBox();
            this.output_dataGrid = new System.Windows.Forms.DataGridView();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.logoBox_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findRes_comboBox = new System.Windows.Forms.ComboBox();
            this.updateCust_btn = new System.Windows.Forms.Button();
            this.deleteCust_btn = new System.Windows.Forms.Button();
            this.createRes_btn = new System.Windows.Forms.Button();
            this.getAllCust_btn = new System.Windows.Forms.Button();
            this.updateRes_btn = new System.Windows.Forms.Button();
            this.deleteRes_btn = new System.Windows.Forms.Button();
            this.getAllRes_btn = new System.Windows.Forms.Button();
            this.CustIDLabel_lbl = new System.Windows.Forms.Label();
            this.errorMessage_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resWeek_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cPnr_input
            // 
            this.cPnr_input.Location = new System.Drawing.Point(243, 137);
            this.cPnr_input.Name = "cPnr_input";
            this.cPnr_input.Size = new System.Drawing.Size(159, 24);
            this.cPnr_input.TabIndex = 0;
            // 
            // cPnr_lbl
            // 
            this.cPnr_lbl.AutoSize = true;
            this.cPnr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cPnr_lbl.Location = new System.Drawing.Point(154, 140);
            this.cPnr_lbl.Name = "cPnr_lbl";
            this.cPnr_lbl.Size = new System.Drawing.Size(83, 17);
            this.cPnr_lbl.TabIndex = 1;
            this.cPnr_lbl.Text = "Customer ID:";
            // 
            // cName_lbl
            // 
            this.cName_lbl.AutoSize = true;
            this.cName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cName_lbl.Location = new System.Drawing.Point(191, 189);
            this.cName_lbl.Name = "cName_lbl";
            this.cName_lbl.Size = new System.Drawing.Size(46, 17);
            this.cName_lbl.TabIndex = 3;
            this.cName_lbl.Text = "Name:";
            // 
            // cName_input
            // 
            this.cName_input.Location = new System.Drawing.Point(243, 186);
            this.cName_input.Name = "cName_input";
            this.cName_input.Size = new System.Drawing.Size(159, 24);
            this.cName_input.TabIndex = 2;
            // 
            // cMail_lbl
            // 
            this.cMail_lbl.AutoSize = true;
            this.cMail_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cMail_lbl.Location = new System.Drawing.Point(195, 238);
            this.cMail_lbl.Name = "cMail_lbl";
            this.cMail_lbl.Size = new System.Drawing.Size(42, 17);
            this.cMail_lbl.TabIndex = 5;
            this.cMail_lbl.Text = "Email:";
            // 
            // cMail_input
            // 
            this.cMail_input.Location = new System.Drawing.Point(243, 235);
            this.cMail_input.Name = "cMail_input";
            this.cMail_input.Size = new System.Drawing.Size(159, 24);
            this.cMail_input.TabIndex = 4;
            // 
            // createCust_btn
            // 
            this.createCust_btn.Location = new System.Drawing.Point(243, 284);
            this.createCust_btn.Name = "createCust_btn";
            this.createCust_btn.Size = new System.Drawing.Size(159, 34);
            this.createCust_btn.TabIndex = 6;
            this.createCust_btn.Text = "Create Customer";
            this.createCust_btn.UseVisualStyleBackColor = true;
            this.createCust_btn.Click += new System.EventHandler(this.regCust_btn_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(424, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 550);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(759, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 550);
            this.label5.TabIndex = 9;
            // 
            // resCabin_comboBox
            // 
            this.resCabin_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resCabin_comboBox.FormattingEnabled = true;
            this.resCabin_comboBox.Items.AddRange(new object[] {
            "WillaWonderland",
            "Snowy Cabin",
            "Presidential Villa",
            "Ice cool cabin"});
            this.resCabin_comboBox.Location = new System.Drawing.Point(572, 189);
            this.resCabin_comboBox.Name = "resCabin_comboBox";
            this.resCabin_comboBox.Size = new System.Drawing.Size(159, 25);
            this.resCabin_comboBox.TabIndex = 10;
            // 
            // resCabin_lbl
            // 
            this.resCabin_lbl.AutoSize = true;
            this.resCabin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.resCabin_lbl.Location = new System.Drawing.Point(484, 192);
            this.resCabin_lbl.Name = "resCabin_lbl";
            this.resCabin_lbl.Size = new System.Drawing.Size(82, 17);
            this.resCabin_lbl.TabIndex = 11;
            this.resCabin_lbl.Text = "Select Cabin:";
            // 
            // resWeek_lbl
            // 
            this.resWeek_lbl.AutoSize = true;
            this.resWeek_lbl.BackColor = System.Drawing.Color.Transparent;
            this.resWeek_lbl.Location = new System.Drawing.Point(486, 240);
            this.resWeek_lbl.Name = "resWeek_lbl";
            this.resWeek_lbl.Size = new System.Drawing.Size(80, 17);
            this.resWeek_lbl.TabIndex = 12;
            this.resWeek_lbl.Text = "Select Week:";
            // 
            // resWeek_input
            // 
            this.resWeek_input.Location = new System.Drawing.Point(572, 238);
            this.resWeek_input.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.resWeek_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resWeek_input.Name = "resWeek_input";
            this.resWeek_input.Size = new System.Drawing.Size(89, 24);
            this.resWeek_input.TabIndex = 13;
            this.resWeek_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkAvail_btn
            // 
            this.checkAvail_btn.Location = new System.Drawing.Point(572, 284);
            this.checkAvail_btn.Name = "checkAvail_btn";
            this.checkAvail_btn.Size = new System.Drawing.Size(159, 34);
            this.checkAvail_btn.TabIndex = 14;
            this.checkAvail_btn.Text = "Check Availability";
            this.checkAvail_btn.UseVisualStyleBackColor = true;
            this.checkAvail_btn.Click += new System.EventHandler(this.checkAvail_btn_Click);
            // 
            // resCust_input
            // 
            this.resCust_input.Location = new System.Drawing.Point(572, 140);
            this.resCust_input.Name = "resCust_input";
            this.resCust_input.Size = new System.Drawing.Size(159, 24);
            this.resCust_input.TabIndex = 15;
            // 
            // resCust_lbl
            // 
            this.resCust_lbl.AutoSize = true;
            this.resCust_lbl.BackColor = System.Drawing.Color.Transparent;
            this.resCust_lbl.Location = new System.Drawing.Point(483, 143);
            this.resCust_lbl.Name = "resCust_lbl";
            this.resCust_lbl.Size = new System.Drawing.Size(83, 17);
            this.resCust_lbl.TabIndex = 16;
            this.resCust_lbl.Text = "Customer ID:";
            // 
            // getCustByID_btn
            // 
            this.getCustByID_btn.Location = new System.Drawing.Point(243, 445);
            this.getCustByID_btn.Name = "getCustByID_btn";
            this.getCustByID_btn.Size = new System.Drawing.Size(159, 34);
            this.getCustByID_btn.TabIndex = 19;
            this.getCustByID_btn.Text = "Find Customer";
            this.getCustByID_btn.UseVisualStyleBackColor = true;
            this.getCustByID_btn.Click += new System.EventHandler(this.findCust_btn_Click);
            // 
            // findCust_input
            // 
            this.findCust_input.Location = new System.Drawing.Point(243, 396);
            this.findCust_input.Name = "findCust_input";
            this.findCust_input.Size = new System.Drawing.Size(159, 24);
            this.findCust_input.TabIndex = 18;
            // 
            // getResByID_btn
            // 
            this.getResByID_btn.Location = new System.Drawing.Point(572, 445);
            this.getResByID_btn.Name = "getResByID_btn";
            this.getResByID_btn.Size = new System.Drawing.Size(159, 34);
            this.getResByID_btn.TabIndex = 19;
            this.getResByID_btn.Text = "Find Reservation";
            this.getResByID_btn.UseVisualStyleBackColor = true;
            this.getResByID_btn.Click += new System.EventHandler(this.findResByID_btn_Click);
            // 
            // findcPnr_lbl
            // 
            this.findcPnr_lbl.AutoSize = true;
            this.findcPnr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.findcPnr_lbl.Location = new System.Drawing.Point(154, 400);
            this.findcPnr_lbl.Name = "findcPnr_lbl";
            this.findcPnr_lbl.Size = new System.Drawing.Size(83, 17);
            this.findcPnr_lbl.TabIndex = 21;
            this.findcPnr_lbl.Text = "Customer ID:";
            // 
            // findRes_input
            // 
            this.findRes_input.Location = new System.Drawing.Point(572, 397);
            this.findRes_input.Name = "findRes_input";
            this.findRes_input.Size = new System.Drawing.Size(159, 24);
            this.findRes_input.TabIndex = 23;
            // 
            // output_dataGrid
            // 
            this.output_dataGrid.AccessibleDescription = "";
            this.output_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.output_dataGrid.BackgroundColor = System.Drawing.Color.SeaShell;
            this.output_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_dataGrid.Location = new System.Drawing.Point(786, 140);
            this.output_dataGrid.Name = "output_dataGrid";
            this.output_dataGrid.Size = new System.Drawing.Size(433, 289);
            this.output_dataGrid.TabIndex = 25;
            // 
            // logoBox
            // 
            this.logoBox.BackColor = System.Drawing.Color.Transparent;
            this.logoBox.BackgroundImage = global::HotelApp.Properties.Resources.logo;
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoBox.Location = new System.Drawing.Point(2, 0);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(112, 108);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoBox.TabIndex = 26;
            this.logoBox.TabStop = false;
            // 
            // logoBox_lbl
            // 
            this.logoBox_lbl.AutoSize = true;
            this.logoBox_lbl.BackColor = System.Drawing.Color.Transparent;
            this.logoBox_lbl.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.logoBox_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.logoBox_lbl.Location = new System.Drawing.Point(18, 111);
            this.logoBox_lbl.Name = "logoBox_lbl";
            this.logoBox_lbl.Size = new System.Drawing.Size(80, 17);
            this.logoBox_lbl.TabIndex = 27;
            this.logoBox_lbl.Text = "Version: 1.0";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(1236, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 550);
            this.label1.TabIndex = 28;
            // 
            // findRes_comboBox
            // 
            this.findRes_comboBox.FormattingEnabled = true;
            this.findRes_comboBox.Items.AddRange(new object[] {
            "Reservation ID ",
            "Customer ID"});
            this.findRes_comboBox.Location = new System.Drawing.Point(445, 396);
            this.findRes_comboBox.Name = "findRes_comboBox";
            this.findRes_comboBox.Size = new System.Drawing.Size(121, 25);
            this.findRes_comboBox.TabIndex = 29;
            // 
            // updateCust_btn
            // 
            this.updateCust_btn.Location = new System.Drawing.Point(786, 445);
            this.updateCust_btn.Name = "updateCust_btn";
            this.updateCust_btn.Size = new System.Drawing.Size(78, 34);
            this.updateCust_btn.TabIndex = 30;
            this.updateCust_btn.Text = "Update";
            this.updateCust_btn.UseVisualStyleBackColor = true;
            this.updateCust_btn.Click += new System.EventHandler(this.updateCust_btn_Click);
            // 
            // deleteCust_btn
            // 
            this.deleteCust_btn.Location = new System.Drawing.Point(870, 445);
            this.deleteCust_btn.Name = "deleteCust_btn";
            this.deleteCust_btn.Size = new System.Drawing.Size(78, 34);
            this.deleteCust_btn.TabIndex = 31;
            this.deleteCust_btn.Text = "Delete";
            this.deleteCust_btn.UseVisualStyleBackColor = true;
            this.deleteCust_btn.Click += new System.EventHandler(this.deleteCust_btn_Click);
            // 
            // createRes_btn
            // 
            this.createRes_btn.AutoEllipsis = true;
            this.createRes_btn.Location = new System.Drawing.Point(572, 324);
            this.createRes_btn.Name = "createRes_btn";
            this.createRes_btn.Size = new System.Drawing.Size(159, 34);
            this.createRes_btn.TabIndex = 32;
            this.createRes_btn.Text = "Create Reservation";
            this.createRes_btn.UseVisualStyleBackColor = true;
            this.createRes_btn.Visible = false;
            this.createRes_btn.Click += new System.EventHandler(this.createRes_btn_Click);
            // 
            // getAllCust_btn
            // 
            this.getAllCust_btn.Location = new System.Drawing.Point(243, 502);
            this.getAllCust_btn.Name = "getAllCust_btn";
            this.getAllCust_btn.Size = new System.Drawing.Size(159, 33);
            this.getAllCust_btn.TabIndex = 33;
            this.getAllCust_btn.Text = "List All Customers";
            this.getAllCust_btn.UseVisualStyleBackColor = true;
            this.getAllCust_btn.Click += new System.EventHandler(this.findAllCust_btn_Click);
            // 
            // updateRes_btn
            // 
            this.updateRes_btn.Location = new System.Drawing.Point(786, 445);
            this.updateRes_btn.Name = "updateRes_btn";
            this.updateRes_btn.Size = new System.Drawing.Size(78, 34);
            this.updateRes_btn.TabIndex = 34;
            this.updateRes_btn.Text = "Update";
            this.updateRes_btn.UseVisualStyleBackColor = true;
            this.updateRes_btn.Visible = false;
            this.updateRes_btn.Click += new System.EventHandler(this.updateRes_btn_Click);
            // 
            // deleteRes_btn
            // 
            this.deleteRes_btn.Location = new System.Drawing.Point(870, 445);
            this.deleteRes_btn.Name = "deleteRes_btn";
            this.deleteRes_btn.Size = new System.Drawing.Size(78, 34);
            this.deleteRes_btn.TabIndex = 35;
            this.deleteRes_btn.TabStop = false;
            this.deleteRes_btn.Text = "Delete";
            this.deleteRes_btn.UseVisualStyleBackColor = true;
            this.deleteRes_btn.Visible = false;
            this.deleteRes_btn.Click += new System.EventHandler(this.deleteRes_btn_Click);
            // 
            // getAllRes_btn
            // 
            this.getAllRes_btn.Location = new System.Drawing.Point(572, 502);
            this.getAllRes_btn.Name = "getAllRes_btn";
            this.getAllRes_btn.Size = new System.Drawing.Size(159, 34);
            this.getAllRes_btn.TabIndex = 36;
            this.getAllRes_btn.Text = "List All Reservations";
            this.getAllRes_btn.UseVisualStyleBackColor = true;
            this.getAllRes_btn.Click += new System.EventHandler(this.findAllRes_btn_Click);
            // 
            // CustIDLabel_lbl
            // 
            this.CustIDLabel_lbl.AutoSize = true;
            this.CustIDLabel_lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CustIDLabel_lbl.Location = new System.Drawing.Point(240, 117);
            this.CustIDLabel_lbl.Name = "CustIDLabel_lbl";
            this.CustIDLabel_lbl.Size = new System.Drawing.Size(103, 17);
            this.CustIDLabel_lbl.TabIndex = 38;
            this.CustIDLabel_lbl.Text = "ÅÅMMDD-XXXX";
            // 
            // errorMessage_lbl
            // 
            this.errorMessage_lbl.AutoSize = true;
            this.errorMessage_lbl.Location = new System.Drawing.Point(18, 574);
            this.errorMessage_lbl.Name = "errorMessage_lbl";
            this.errorMessage_lbl.Size = new System.Drawing.Size(0, 17);
            this.errorMessage_lbl.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(569, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "ÅÅMMDD-XXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(240, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "ÅÅMMDD-XXXX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HotelApp.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1282, 611);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorMessage_lbl);
            this.Controls.Add(this.CustIDLabel_lbl);
            this.Controls.Add(this.getAllRes_btn);
            this.Controls.Add(this.deleteRes_btn);
            this.Controls.Add(this.updateRes_btn);
            this.Controls.Add(this.getAllCust_btn);
            this.Controls.Add(this.createRes_btn);
            this.Controls.Add(this.deleteCust_btn);
            this.Controls.Add(this.updateCust_btn);
            this.Controls.Add(this.findRes_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox_lbl);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.output_dataGrid);
            this.Controls.Add(this.findRes_input);
            this.Controls.Add(this.findcPnr_lbl);
            this.Controls.Add(this.getResByID_btn);
            this.Controls.Add(this.findCust_input);
            this.Controls.Add(this.getCustByID_btn);
            this.Controls.Add(this.resCust_lbl);
            this.Controls.Add(this.resCust_input);
            this.Controls.Add(this.checkAvail_btn);
            this.Controls.Add(this.resWeek_input);
            this.Controls.Add(this.resWeek_lbl);
            this.Controls.Add(this.resCabin_lbl);
            this.Controls.Add(this.resCabin_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createCust_btn);
            this.Controls.Add(this.cMail_lbl);
            this.Controls.Add(this.cMail_input);
            this.Controls.Add(this.cName_lbl);
            this.Controls.Add(this.cName_input);
            this.Controls.Add(this.cPnr_lbl);
            this.Controls.Add(this.cPnr_input);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Ski Village - Booking System";
            ((System.ComponentModel.ISupportInitialize)(this.resWeek_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cPnr_input;
        private System.Windows.Forms.Label cPnr_lbl;
        private System.Windows.Forms.Label cName_lbl;
        private System.Windows.Forms.TextBox cName_input;
        private System.Windows.Forms.Label cMail_lbl;
        private System.Windows.Forms.TextBox cMail_input;
        private System.Windows.Forms.Button createCust_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox resCabin_comboBox;
        private System.Windows.Forms.Label resCabin_lbl;
        private System.Windows.Forms.Label resWeek_lbl;
        private System.Windows.Forms.NumericUpDown resWeek_input;
        private System.Windows.Forms.Button checkAvail_btn;
        private System.Windows.Forms.TextBox resCust_input;
        private System.Windows.Forms.Label resCust_lbl;
        private System.Windows.Forms.Button getCustByID_btn;
        private System.Windows.Forms.TextBox findCust_input;
        private System.Windows.Forms.Button getResByID_btn;
        private System.Windows.Forms.Label findcPnr_lbl;
        private System.Windows.Forms.TextBox findRes_input;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label logoBox_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox findRes_comboBox;
        private System.Windows.Forms.Button updateCust_btn;
        private System.Windows.Forms.Button deleteCust_btn;
        private System.Windows.Forms.Button createRes_btn;
        private System.Windows.Forms.Button getAllCust_btn;
        private System.Windows.Forms.Button updateRes_btn;
        private System.Windows.Forms.Button deleteRes_btn;
        private System.Windows.Forms.Button getAllRes_btn;
        public System.Windows.Forms.DataGridView output_dataGrid;
        private System.Windows.Forms.Label CustIDLabel_lbl;
        private System.Windows.Forms.Label errorMessage_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


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
            this.regCust_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resCabin_comboBox = new System.Windows.Forms.ComboBox();
            this.resCabin_lbl = new System.Windows.Forms.Label();
            this.resWeek_lbl = new System.Windows.Forms.Label();
            this.resWeek_input = new System.Windows.Forms.NumericUpDown();
            this.checkAvail_btn = new System.Windows.Forms.Button();
            this.resCust_input = new System.Windows.Forms.TextBox();
            this.resCust_lbl = new System.Windows.Forms.Label();
            this.findCust_btn = new System.Windows.Forms.Button();
            this.findCust_input = new System.Windows.Forms.TextBox();
            this.findRes_btn = new System.Windows.Forms.Button();
            this.findcPnr_lbl = new System.Windows.Forms.Label();
            this.findRes_input = new System.Windows.Forms.TextBox();
            this.output_dataGrid = new System.Windows.Forms.DataGridView();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.logoBox_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findRes_comboBox = new System.Windows.Forms.ComboBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.createRes_btn = new System.Windows.Forms.Button();
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
            // regCust_btn
            // 
            this.regCust_btn.Location = new System.Drawing.Point(243, 284);
            this.regCust_btn.Name = "regCust_btn";
            this.regCust_btn.Size = new System.Drawing.Size(159, 34);
            this.regCust_btn.TabIndex = 6;
            this.regCust_btn.Text = "Register Customer";
            this.regCust_btn.UseVisualStyleBackColor = true;
            this.regCust_btn.Click += new System.EventHandler(this.regCust_btn_Click);
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
            this.resCabin_comboBox.FormattingEnabled = true;
            this.resCabin_comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.resCabin_comboBox.Location = new System.Drawing.Point(572, 189);
            this.resCabin_comboBox.Name = "resCabin_comboBox";
            this.resCabin_comboBox.Size = new System.Drawing.Size(159, 25);
            this.resCabin_comboBox.TabIndex = 10;
            resCabin_comboBox.SelectedIndex = 0;
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
            // findCust_btn
            // 
            this.findCust_btn.Location = new System.Drawing.Point(243, 445);
            this.findCust_btn.Name = "findCust_btn";
            this.findCust_btn.Size = new System.Drawing.Size(159, 34);
            this.findCust_btn.TabIndex = 19;
            this.findCust_btn.Text = "Find Customer";
            this.findCust_btn.UseVisualStyleBackColor = true;
            this.findCust_btn.Click += new System.EventHandler(this.findCust_btn_Click);
            // 
            // findCust_input
            // 
            this.findCust_input.Location = new System.Drawing.Point(243, 396);
            this.findCust_input.Name = "findCust_input";
            this.findCust_input.Size = new System.Drawing.Size(159, 24);
            this.findCust_input.TabIndex = 18;
            // 
            // findRes_btn
            // 
            this.findRes_btn.Location = new System.Drawing.Point(572, 445);
            this.findRes_btn.Name = "findRes_btn";
            this.findRes_btn.Size = new System.Drawing.Size(159, 34);
            this.findRes_btn.TabIndex = 19;
            this.findRes_btn.Text = "Find Reservation";
            this.findRes_btn.UseVisualStyleBackColor = true;
            this.findRes_btn.Click += new System.EventHandler(this.findRes_btn_Click);
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
            findRes_comboBox.SelectedIndex = 0;
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(786, 445);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(78, 34);
            this.update_btn.TabIndex = 30;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(870, 445);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(78, 34);
            this.delete_btn.TabIndex = 31;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HotelApp.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1282, 611);
            this.Controls.Add(this.createRes_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.findRes_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoBox_lbl);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.output_dataGrid);
            this.Controls.Add(this.findRes_input);
            this.Controls.Add(this.findcPnr_lbl);
            this.Controls.Add(this.findRes_btn);
            this.Controls.Add(this.findCust_input);
            this.Controls.Add(this.findCust_btn);
            this.Controls.Add(this.resCust_lbl);
            this.Controls.Add(this.resCust_input);
            this.Controls.Add(this.checkAvail_btn);
            this.Controls.Add(this.resWeek_input);
            this.Controls.Add(this.resWeek_lbl);
            this.Controls.Add(this.resCabin_lbl);
            this.Controls.Add(this.resCabin_comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.regCust_btn);
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
        private System.Windows.Forms.Button regCust_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox resCabin_comboBox;
        private System.Windows.Forms.Label resCabin_lbl;
        private System.Windows.Forms.Label resWeek_lbl;
        private System.Windows.Forms.NumericUpDown resWeek_input;
        private System.Windows.Forms.Button checkAvail_btn;
        private System.Windows.Forms.TextBox resCust_input;
        private System.Windows.Forms.Label resCust_lbl;
        private System.Windows.Forms.Button findCust_btn;
        private System.Windows.Forms.TextBox findCust_input;
        private System.Windows.Forms.Button findRes_btn;
        private System.Windows.Forms.Label findcPnr_lbl;
        private System.Windows.Forms.TextBox findRes_input;
        private System.Windows.Forms.DataGridView output_dataGrid;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label logoBox_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox findRes_comboBox;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button createRes_btn;
    }
}


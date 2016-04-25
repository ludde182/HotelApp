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
            this.findRes_input = new System.Windows.Forms.TextBox();
            this.findRes_btn = new System.Windows.Forms.Button();
            this.findcPnr_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.output_dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.resWeek_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // cPnr_input
            // 
            this.cPnr_input.Location = new System.Drawing.Point(113, 122);
            this.cPnr_input.Name = "cPnr_input";
            this.cPnr_input.Size = new System.Drawing.Size(137, 20);
            this.cPnr_input.TabIndex = 0;
            // 
            // cPnr_lbl
            // 
            this.cPnr_lbl.AutoSize = true;
            this.cPnr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cPnr_lbl.Location = new System.Drawing.Point(16, 125);
            this.cPnr_lbl.Name = "cPnr_lbl";
            this.cPnr_lbl.Size = new System.Drawing.Size(94, 13);
            this.cPnr_lbl.TabIndex = 1;
            this.cPnr_lbl.Text = "Personal Number: ";
            // 
            // cName_lbl
            // 
            this.cName_lbl.AutoSize = true;
            this.cName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cName_lbl.Location = new System.Drawing.Point(72, 163);
            this.cName_lbl.Name = "cName_lbl";
            this.cName_lbl.Size = new System.Drawing.Size(38, 13);
            this.cName_lbl.TabIndex = 3;
            this.cName_lbl.Text = "Name:";
            // 
            // cName_input
            // 
            this.cName_input.Location = new System.Drawing.Point(113, 160);
            this.cName_input.Name = "cName_input";
            this.cName_input.Size = new System.Drawing.Size(137, 20);
            this.cName_input.TabIndex = 2;
            // 
            // cMail_lbl
            // 
            this.cMail_lbl.AutoSize = true;
            this.cMail_lbl.BackColor = System.Drawing.Color.Transparent;
            this.cMail_lbl.Location = new System.Drawing.Point(75, 201);
            this.cMail_lbl.Name = "cMail_lbl";
            this.cMail_lbl.Size = new System.Drawing.Size(35, 13);
            this.cMail_lbl.TabIndex = 5;
            this.cMail_lbl.Text = "Email:";
            this.cMail_lbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // cMail_input
            // 
            this.cMail_input.Location = new System.Drawing.Point(113, 198);
            this.cMail_input.Name = "cMail_input";
            this.cMail_input.Size = new System.Drawing.Size(137, 20);
            this.cMail_input.TabIndex = 4;
            this.cMail_input.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // regCust_btn
            // 
            this.regCust_btn.Location = new System.Drawing.Point(113, 249);
            this.regCust_btn.Name = "regCust_btn";
            this.regCust_btn.Size = new System.Drawing.Size(137, 26);
            this.regCust_btn.TabIndex = 6;
            this.regCust_btn.Text = "Register Customer";
            this.regCust_btn.UseVisualStyleBackColor = true;
            this.regCust_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(277, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 420);
            this.label4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(581, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 420);
            this.label5.TabIndex = 9;
            // 
            // resCabin_comboBox
            // 
            this.resCabin_comboBox.FormattingEnabled = true;
            this.resCabin_comboBox.Location = new System.Drawing.Point(384, 160);
            this.resCabin_comboBox.Name = "resCabin_comboBox";
            this.resCabin_comboBox.Size = new System.Drawing.Size(121, 21);
            this.resCabin_comboBox.TabIndex = 10;
            // 
            // resCabin_lbl
            // 
            this.resCabin_lbl.AutoSize = true;
            this.resCabin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.resCabin_lbl.Location = new System.Drawing.Point(311, 164);
            this.resCabin_lbl.Name = "resCabin_lbl";
            this.resCabin_lbl.Size = new System.Drawing.Size(70, 13);
            this.resCabin_lbl.TabIndex = 11;
            this.resCabin_lbl.Text = "Select Cabin:";
            // 
            // resWeek_lbl
            // 
            this.resWeek_lbl.AutoSize = true;
            this.resWeek_lbl.BackColor = System.Drawing.Color.Transparent;
            this.resWeek_lbl.Location = new System.Drawing.Point(311, 201);
            this.resWeek_lbl.Name = "resWeek_lbl";
            this.resWeek_lbl.Size = new System.Drawing.Size(72, 13);
            this.resWeek_lbl.TabIndex = 12;
            this.resWeek_lbl.Text = "Select Week:";
            // 
            // resWeek_input
            // 
            this.resWeek_input.Location = new System.Drawing.Point(386, 198);
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
            this.resWeek_input.Size = new System.Drawing.Size(65, 20);
            this.resWeek_input.TabIndex = 13;
            this.resWeek_input.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkAvail_btn
            // 
            this.checkAvail_btn.Location = new System.Drawing.Point(384, 249);
            this.checkAvail_btn.Name = "checkAvail_btn";
            this.checkAvail_btn.Size = new System.Drawing.Size(137, 26);
            this.checkAvail_btn.TabIndex = 14;
            this.checkAvail_btn.Text = "Check Availability";
            this.checkAvail_btn.UseVisualStyleBackColor = true;
            this.checkAvail_btn.Click += new System.EventHandler(this.checkAvail_btn_Click);
            // 
            // resCust_input
            // 
            this.resCust_input.Location = new System.Drawing.Point(384, 125);
            this.resCust_input.Name = "resCust_input";
            this.resCust_input.Size = new System.Drawing.Size(137, 20);
            this.resCust_input.TabIndex = 15;
            // 
            // resCust_lbl
            // 
            this.resCust_lbl.AutoSize = true;
            this.resCust_lbl.BackColor = System.Drawing.Color.Transparent;
            this.resCust_lbl.Location = new System.Drawing.Point(327, 129);
            this.resCust_lbl.Name = "resCust_lbl";
            this.resCust_lbl.Size = new System.Drawing.Size(54, 13);
            this.resCust_lbl.TabIndex = 16;
            this.resCust_lbl.Text = "Customer:";
            // 
            // findCust_btn
            // 
            this.findCust_btn.Location = new System.Drawing.Point(113, 384);
            this.findCust_btn.Name = "findCust_btn";
            this.findCust_btn.Size = new System.Drawing.Size(137, 26);
            this.findCust_btn.TabIndex = 17;
            this.findCust_btn.Text = "Find Customer";
            this.findCust_btn.UseVisualStyleBackColor = true;
            this.findCust_btn.Click += new System.EventHandler(this.findCust_btn_Click);
            // 
            // findCust_input
            // 
            this.findCust_input.Location = new System.Drawing.Point(113, 347);
            this.findCust_input.Name = "findCust_input";
            this.findCust_input.Size = new System.Drawing.Size(137, 20);
            this.findCust_input.TabIndex = 18;
            this.findCust_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // findRes_input
            // 
            this.findRes_input.Location = new System.Drawing.Point(384, 347);
            this.findRes_input.Name = "findRes_input";
            this.findRes_input.Size = new System.Drawing.Size(137, 20);
            this.findRes_input.TabIndex = 20;
            // 
            // findRes_btn
            // 
            this.findRes_btn.Location = new System.Drawing.Point(384, 384);
            this.findRes_btn.Name = "findRes_btn";
            this.findRes_btn.Size = new System.Drawing.Size(137, 26);
            this.findRes_btn.TabIndex = 19;
            this.findRes_btn.Text = "Find Reservation";
            this.findRes_btn.UseVisualStyleBackColor = true;
            // 
            // findcPnr_lbl
            // 
            this.findcPnr_lbl.AutoSize = true;
            this.findcPnr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.findcPnr_lbl.Location = new System.Drawing.Point(16, 350);
            this.findcPnr_lbl.Name = "findcPnr_lbl";
            this.findcPnr_lbl.Size = new System.Drawing.Size(94, 13);
            this.findcPnr_lbl.TabIndex = 21;
            this.findcPnr_lbl.Text = "Personal Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(287, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Personal Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(287, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Personal Number: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 303);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 23;
            // 
            // output_dataGrid
            // 
            this.output_dataGrid.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.output_dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.output_dataGrid.Location = new System.Drawing.Point(586, 125);
            this.output_dataGrid.Name = "output_dataGrid";
            this.output_dataGrid.Size = new System.Drawing.Size(371, 198);
            this.output_dataGrid.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HotelApp.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(961, 466);
            this.Controls.Add(this.output_dataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findcPnr_lbl);
            this.Controls.Add(this.findRes_input);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ski Village - Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resWeek_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.output_dataGrid)).EndInit();
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
        private System.Windows.Forms.TextBox findRes_input;
        private System.Windows.Forms.Button findRes_btn;
        private System.Windows.Forms.Label findcPnr_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView output_dataGrid;
    }
}


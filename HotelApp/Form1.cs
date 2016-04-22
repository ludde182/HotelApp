﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelApp.DAL;
using HotelApp;
using HotelApp.Controller;
using HotelApp.Model;

namespace HotelApp
{
    public partial class Form1 : Form
    {

        DAL.DAL d = new DAL.DAL();
        Controller.Controller  ctrl = new Controller.Controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Cabin' table. You can move, or remove it, as needed.
            this.cabinTableAdapter.Fill(this.dbDataSet.Cabin);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Customer c = new Customer();
                c.cPnr = cPnr_input.Text.ToString();
                c.cName = cName_input.Text.ToString();
                c.cMail = cMail_input.Text.ToString();
                ctrl.CreateCustomer(c);
            return;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
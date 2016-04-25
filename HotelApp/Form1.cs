using System;
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
        Utility ut = new Utility();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.Cabin' table. You can move, or remove it, as needed.
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkAvail_btn_Click(object sender, EventArgs e)
        {

        }

        private void findCust_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl.GetCustomerByCpnr(findCust_input.Text);
            output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(findCust_input.Text).DefaultView;
            ut.updateCustomer(dt);
        }
    }
}

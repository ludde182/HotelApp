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

        Controller.Controller  ctrl = new Controller.Controller();
        Utility ut = new Utility();
        

        public Form1()
        {
            InitializeComponent();
        }


        private void findCust_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = ctrl.GetCustomerByCpnr(findCust_input.Text);
            output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(findCust_input.Text).DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void regCust_btn_Click(object sender, EventArgs e)
        {
            string cPnr = cPnr_input.Text;
            string cName = cName_input.Text;
            string cMail = cMail_input.Text;

            ctrl.CreateCustomer(cPnr, cName, cMail);
            output_dataGrid.DataSource = ctrl.GetAllCustomers();
        }

        private void findRes_btn_Click(object sender, EventArgs e)
        {
            
            if (findRes_comboBox.SelectedIndex == 0)
            {
                string resId = findRes_input.Text;
                output_dataGrid.DataSource = ctrl.GetReservationByResId(resId);    
            }

            else if (findRes_comboBox.SelectedIndex == 1)
            {
                string cPnr = findRes_input.Text;
                output_dataGrid.DataSource = ctrl.GetReservationByCpnr(cPnr);
            }
        }

        private void checkAvail_btn_Click(object sender, EventArgs e)
        {
            string cPnr = resCust_input.Text;
            int cabinNo = Convert.ToInt32(resCabin_comboBox.SelectedItem.ToString());
            int rWeek = (int) resWeek_input.Value;

            if (ctrl.CheckReservation(cabinNo,rWeek))
            {
                checkAvail_btn.Visible = false;
                createRes_btn.Visible = true;
            }
        }

        private void createRes_btn_Click(object sender, EventArgs e)
        {
            string cPnr = resCust_input.Text;
            int cabinNo = resCabin_comboBox.SelectedIndex + 1;
            int rWeek =  (int) resWeek_input.Value;

            ctrl.CreateReservation(cPnr, cabinNo, rWeek);
            output_dataGrid.DataSource = ctrl.GetReservationByCpnr(cPnr);
            checkAvail_btn.Visible = true;
            createRes_btn.Visible = false;
        }
    }
}

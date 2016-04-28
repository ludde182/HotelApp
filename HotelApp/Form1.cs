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
using System.Net;
using HotelApp.Utility;


namespace HotelApp
{
    public partial class Form1 : Form
    {

        Controller.Controller ctrl = new Controller.Controller();
        Utility.Utility ut = new Utility.Utility();

        public Form1()
        {



            InitializeComponent();
            output_dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            output_dataGrid.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            output_dataGrid.MultiSelect = false;
            createResLabel_lbl.Visible = false;

            resCust_input.TextChanged += new EventHandler((s, e) =>
            {
                createRes_btn.Visible = false;
                createResLabel_lbl.Visible = false;
            });

            resCabin_comboBox.TextChanged += new EventHandler((s, e) =>
            {
                createRes_btn.Visible = false;
                createResLabel_lbl.Visible = false;
            });

            resWeek_input.TextChanged += new EventHandler((s, e) =>
            {
                createRes_btn.Visible = false;
                createResLabel_lbl.Visible = false;
            });
            findRes_comboBox.SelectedIndex = 0;
            resCabin_comboBox.SelectedIndex = 0;

        }

        //FIND ALL METHODS

        //FIND ALL CUSTOMERS
        private void findAllCust_btn_Click(object sender, EventArgs e)
        {
            findAllCust_btn.Enabled = false;
            output_dataGrid.DataSource = null;
            output_dataGrid.Rows.Clear();
            output_dataGrid.DataSource = ctrl.GetAllCustomers();
            if (output_dataGrid.DataSource != null)
            {

                output_dataGrid.Columns[0].ReadOnly = true;
                output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                updateCust_btn.Visible = true;
                deleteCust_btn.Visible = true;
                updateRes_btn.Visible = false;
                deleteRes_btn.Visible = false;
            }
            findAllCust_btn.Enabled = true;
        }

        //FIND ALL RESERVATIONS
        private void findAllRes_btn_Click(object sender, EventArgs e)
        {
            findAllRes_btn.Enabled = false;
            output_dataGrid.DataSource = null;
            output_dataGrid.Rows.Clear();
            output_dataGrid.DataSource = ctrl.GetAllReservations();


            if (output_dataGrid.DataSource != null)
            {

                output_dataGrid.Columns[0].ReadOnly = true;
                output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                updateRes_btn.Visible = true;
                deleteRes_btn.Visible = true;
                deleteCust_btn.Visible = false;
                updateCust_btn.Visible = false;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No reservations found");

            }
            findAllRes_btn.Enabled = true;

        }

        //FIND BY ID METHODS

        //FIND CUSTOMER BY cPnr
        private void findCust_btn_Click(object sender, EventArgs e)
        {
            findCustByID_btn.Enabled = false;
            output_dataGrid.DataSource = null;
            output_dataGrid.Rows.Clear();
            DataTable dt = ctrl.GetCustomerByCpnr(findCust_input.Text);
            output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(findCust_input.Text).DefaultView;
            if (output_dataGrid.Rows.Count > 1)
            {
                output_dataGrid.Columns[0].ReadOnly = true;
                output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                updateCust_btn.Visible = true;
                deleteCust_btn.Visible = true;
                updateRes_btn.Visible = false;
                deleteRes_btn.Visible = false;

            }

            else
            {
                System.Windows.Forms.MessageBox.Show("Could not find the Customer with cPnr: " + findCust_input.Text);
            }
            findCustByID_btn.Enabled = true;
        }


        //FIND RESERVATION BY resID OR cPnr   
        private void findResByID_btn_Click(object sender, EventArgs e)
        {
            findResByID_btn.Enabled = false;

            if (findRes_comboBox.SelectedIndex == 0)
            {
                string resId = findRes_input.Text;
                output_dataGrid.DataSource = null;
                output_dataGrid.Rows.Clear();

                if(resId.Length < 10)
                output_dataGrid.DataSource = ctrl.GetReservationByResId(resId);

                if (output_dataGrid.Rows.Count > 1)
                {

                    output_dataGrid.Columns[0].ReadOnly = true;
                    output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                    updateRes_btn.Visible = true;
                    deleteCust_btn.Visible = false;
                    updateCust_btn.Visible = false;
                    deleteRes_btn.Visible = true;

                }

                else
                {
                    System.Windows.Forms.MessageBox.Show("Could not find the reservation with the resID: " + findRes_input.Text);
                }
            }


            else if (findRes_comboBox.SelectedIndex == 1)
            {
                string cPnr = findRes_input.Text;
                output_dataGrid.DataSource = null;
                output_dataGrid.Rows.Clear();

                if (cPnr.Length < 12)
                    output_dataGrid.DataSource = ctrl.GetReservationByCpnr(cPnr);

                if (output_dataGrid.Rows.Count > 1)
                {

                    output_dataGrid.Columns[0].ReadOnly = true;
                    output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                    updateRes_btn.Visible = true;
                    deleteCust_btn.Visible = false;
                    updateCust_btn.Visible = false;
                    deleteRes_btn.Visible = true;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Could not find the reservation with the cPnr: " + findRes_input.Text);
                }
            }
            findResByID_btn.Enabled = true;
        }

        //CHECK AVAILABILITY METHOD

        private void checkAvail_btn_Click(object sender, EventArgs e)
        {
            checkAvail_btn.Enabled = false;
            string cPnr = null;
            int cabinNo = 0;
            int rWeek = 0;
            if (resCust_input.Text == null || resCust_input.Text == "" || resCabin_comboBox.Text == null || resCabin_comboBox.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("You have to select a customer, a cabin and a week!");

            }
            else {
                cPnr = resCust_input.Text;
                cabinNo = resCabin_comboBox.SelectedIndex + 1;
                rWeek = (int)resWeek_input.Value;

                if (ctrl.CheckReservation(cabinNo, rWeek))
                {
                    checkAvail_btn.Visible = true;
                    createRes_btn.Visible = true;
                    createResLabel_lbl.Visible = true;

                }
            }
            checkAvail_btn.Enabled = true;
        }


        //UPDATE METHODS

        //UPDATE CUSTOMER
        private void updateCust_btn_Click(object sender, EventArgs e)
        {
            updateCust_btn.Enabled = false;
            try
            {
                if (output_dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];
                    string cPnr = row.Cells["cPnr"].Value.ToString();
                    string cName = row.Cells["cName"].Value.ToString();
                    string cMail = row.Cells["cMail"].Value.ToString();

                    ctrl.UpdateCustomer(cPnr, cName, cMail);
                    output_dataGrid.ClearSelection();
                    findAllCust_btn.PerformClick();
                    System.Windows.Forms.MessageBox.Show("Customer with cPnr: " + cPnr + " is updated!");
                }
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("You have to select a Customer!");

            }
            updateCust_btn.Enabled = true;
        }

        //UPDATE RESERVATION

        private void updateRes_btn_Click(object sender, EventArgs e)
        {
            updateRes_btn.Enabled = false;

            try
            {
                if (output_dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];
                    string resID = row.Cells["resID"].Value.ToString();
                    string cPnr = row.Cells["cPnr"].Value.ToString();
                    string cabinNo = row.Cells["cabinNo"].Value.ToString();
                    string rWeek = row.Cells["rWeek"].Value.ToString();


                    ctrl.UpdateReservation(resID, cPnr, cabinNo, rWeek);
                    output_dataGrid.ClearSelection();
                    findAllRes_btn.PerformClick();
                    System.Windows.Forms.MessageBox.Show("Reservation with resID: " + resID + " is updated!");
                }
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("You have to select a Reservation");

            }
            updateRes_btn.Enabled = true;
        }


        //CREATE METHODS

        //CREATE CUSTOMER
        private void regCust_btn_Click(object sender, EventArgs e)
        {
            createCust_btn.Enabled = false;

            string cPnr = cPnr_input.Text;
            string cName = cName_input.Text;
            string cMail = cMail_input.Text;

            bool b = false;
            try
            {
                var addr = new System.Net.Mail.MailAddress(cMail);
                b = (addr.Address == cMail);
            }
            catch
            {
                b = false;
            }

            if (cPnr != null && cPnr != "" && cName != null && cName != "" && cMail != null && cMail != "")
            {

                if ((cPnr.Count(char.IsDigit) == 10) && (cPnr[6] == '-') && (cName.Count(char.IsDigit) == 0 && b))
                {
                    if (ctrl.CreateCustomer(cPnr, cName, cMail))
                    {
                        System.Windows.Forms.MessageBox.Show("Customer with cPnr: " + cPnr + " is created!");
                    }
                    output_dataGrid.DataSource = ctrl.GetAllCustomers();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect inputs! Example - cPnr: \"911208-0131\" Name: \"Mats Ucan\" Mail: \"Erdogan@gmail.com\"");
                }

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("You have to fill out every field!");
            }

            //  ut.regCust(cPnr, cName, cMail);

            createCust_btn.Enabled = true;
        }

        //CREATE RESERVATION
        private void createRes_btn_Click(object sender, EventArgs e)
        {
            createRes_btn.Enabled = false;
            createResLabel_lbl.Visible = false;
            string cPnr = resCust_input.Text;
            int cabinNo = resCabin_comboBox.SelectedIndex + 1;
            int rWeek = (int)resWeek_input.Value;

            if (ctrl.CreateReservation(cPnr, cabinNo, rWeek))
            {
                output_dataGrid.DataSource = ctrl.GetReservationByCpnr(cPnr);
                checkAvail_btn.Visible = true;
                createRes_btn.Visible = false;
                createRes_btn.Enabled = true;
            }
            else
            {
                findAllCust_btn_Click(sender, e);
            }
        }

        //DELETE METHODS

        //DELETE CUSTOMER
        private void deleteCust_btn_Click(object sender, EventArgs e)
        {
            deleteCust_btn.Enabled = false;
            try
            {
                if (output_dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];
                    string cPnr = row.Cells["cPnr"].Value.ToString();


                    ctrl.DeleteCustomer(cPnr);
                    output_dataGrid.ClearSelection();
                    findAllCust_btn.PerformClick();
                    System.Windows.Forms.MessageBox.Show("Customer with cPnr : " + cPnr + " is deleted!");

                }
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("You have to select a Customer!");

            }
            deleteCust_btn.Enabled = true;
        }

        //DELETE RESERVATION
        private void deleteRes_btn_Click(object sender, EventArgs e)
        {
            deleteRes_btn.Enabled = false;
            try
            {
                if (output_dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];
                    string resID = row.Cells["resID"].Value.ToString();

                    if (resID != null || resID != "")
                    {
                        ctrl.DeleteReservation(resID);
                        output_dataGrid.ClearSelection();
                        findAllRes_btn.PerformClick();
                        System.Windows.Forms.MessageBox.Show("Reservation with resID : " + resID + " is deleted!");
                    }
                }
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("You have to select a Customer!");

            }
            deleteRes_btn.Enabled = true;

        }

    }
}

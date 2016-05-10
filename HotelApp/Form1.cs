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
using HotelApp.Exception;

namespace HotelApp
{
    public partial class Form1 : Form
    {

        Controller.Controller ctrl = new Controller.Controller();

        public Form1()
        {

            InitializeComponent();
            output_dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            output_dataGrid.SelectionChanged += new EventHandler((s, e) =>
            {

            });

            output_dataGrid.MultiSelect = false;


            //HIDE createRes_btn if text changes
            resCust_input.TextChanged += new EventHandler((s, e) =>
            {
                createRes_btn.Visible = false;

            });

            resCabin_comboBox.TextChanged += new EventHandler((s, e) =>
            {
                createRes_btn.Visible = false;

            });

            resWeek_input.TextChanged += new EventHandler((s, e) =>
            {
                createRes_btn.Visible = false;

            });
            findRes_comboBox.SelectedIndex = 0;
            resCabin_comboBox.SelectedIndex = 0;

        }

        //CLEAR METHOD
        private void clearFields()
        {
            output_dataGrid.DataSource = null;
            output_dataGrid.Rows.Clear();
            infoMessage_lbl.Text = null;
        }

        //GET ALL METHODS

        //GET ALL CUSTOMERS
        private void findAllCust_btn_Click(object sender, EventArgs e)
        {
            getAllCust_btn.Enabled = false; //Standard for every button. Prevents mulitiple clicks. 

            clearFields(); //Standard for every button. Clears the fields.
            try
            {
                output_dataGrid.DataSource = ctrl.GetAllCustomers();

                if (output_dataGrid.DataSource != null)
                {
                    output_dataGrid.Columns[0].ReadOnly = true; //Standard for every output_datagrid btn. Makes the ID read only.
                    output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                    updateCust_btn.Visible = true;
                    deleteCust_btn.Visible = true;
                    updateRes_btn.Visible = false;
                    deleteRes_btn.Visible = false;
                }
            }
            catch (HandleException err) // Standard for every button. Error message thrown from DAL
            {
                infoMessage_lbl.Text = err.errMessage;
            }

            getAllCust_btn.Enabled = true;
        }

        //GET ALL RESERVATIONS
        private void findAllRes_btn_Click(object sender, EventArgs e)
        {
            getAllRes_btn.Enabled = false;
            clearFields();

            try
            {
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
            }
            catch (HandleException err)
            {
                infoMessage_lbl.Text = err.errMessage;
            }

            getAllRes_btn.Enabled = true;

        }

        //GET BY ID METHODS

        //GET CUSTOMER BY cPnr
        private void findCust_btn_Click(object sender, EventArgs e)
        {
            getCustByID_btn.Enabled = false;
            clearFields();

            try
            {
                output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(findCust_input.Text);
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
                    infoMessage_lbl.Text = "The Customer " + findCust_input.Text + " does not exist.";
                }
            }
            catch (HandleException err)
            {
                MessageBox.Show(err.errMessage);
            }
            getCustByID_btn.Enabled = true;
        }


        //GET RESERVATION BY resID OR cPnr   
        private void findResByID_btn_Click(object sender, EventArgs e)
        {
            getResByID_btn.Enabled = false;
            clearFields();

            try
            {
                if (findRes_comboBox.SelectedIndex == 0) //Combobox Index decides which method that get called in DAL
                {
                    string resId = findRes_input.Text;
                    clearFields();

                  if (resId.Length < 10) //resID length check, prevents error in database.
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
                        infoMessage_lbl.Text = ("Could not find the reservation with the resID: " + findRes_input.Text);
                    }
                }

                else if (findRes_comboBox.SelectedIndex == 1)
                {
                    string cPnr = findRes_input.Text;
                    clearFields();

                    if (cPnr.Length < 12) // Prevents error in the database
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
                        infoMessage_lbl.Text = ("Could not find the reservation with the cPnr: " + findRes_input.Text);
                    }
                }
            }

            catch (HandleException err)
            {
                MessageBox.Show(err.errMessage);
            }
            getResByID_btn.Enabled = true;
        }

        //CHECK AVAILABILITY METHOD
        private void checkAvail_btn_Click(object sender, EventArgs e)
        {
            checkAvail_btn.Enabled = false;
            try
            {
                string cPnr = null;
                int cabinNo = 0;
                int rWeek = 0;
                if (resCust_input.Text == null || resCust_input.Text == "" || resCabin_comboBox.Text == null || resCabin_comboBox.Text == "") //null check
                {
                    infoMessage_lbl.Text = "Error! You have to select a customer, a cabin and a week!";
                    checkAvail_btn.Enabled = true;
                }
                else {
                    cPnr = resCust_input.Text;
                    cabinNo = resCabin_comboBox.SelectedIndex + 1;
                    rWeek = (int)resWeek_input.Value;

                    if (ctrl.CheckReservation(cabinNo, rWeek)) //Bool check from DAL
                    {
                        checkAvail_btn.Visible = true;
                        createRes_btn.Visible = true; // Shows createRes button
                        infoMessage_lbl.Text = "The option is available, proceed with \"Create Reservation\".";
                    }
                    else
                    {
                        infoMessage_lbl.Text = "Error! The option isn't available!";
                    }
                }
            }
            catch (HandleException err)
            {
                MessageBox.Show(err.errMessage);
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
                //Check if cells are null
                if (output_dataGrid.SelectedRows.Count > 0)
                {

                    DataGridViewRow row = output_dataGrid.SelectedRows[0];
                    if (row.Cells.Count > 0)
                    {
                        bool rowIsEmpty = true;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                rowIsEmpty = false;
                                break;
                            }
                        }

                        if (rowIsEmpty)
                            infoMessage_lbl.Text = "Select a non null row";
                        else
                        {
                            string cPnr = row.Cells["cPnr"].Value.ToString();
                            string cName = row.Cells["cName"].Value.ToString();
                            string cMail = row.Cells["cMail"].Value.ToString();
                            bool validEmail = false;
                            //Validate email
                            try
                            {
                                var addr = new System.Net.Mail.MailAddress(cMail);
                                validEmail = (addr.Address == cMail);
                            }
                            catch
                            {
                                validEmail = false;
                            }
                            //Prevents empty fields
                            if (cPnr != null && cPnr != "" && cName != null && cName != "" && cMail != null && cMail != "")
                            {
                                // Validates cPnr and Name
                                if ((validEmail && cPnr.Count(char.IsDigit) == 10) && (cPnr[6] == '-') && (cName.Count(char.IsDigit) == 0) && cPnr.Length == 11)
                                {
                                    ctrl.UpdateCustomer(cPnr, cName, cMail);
                                    output_dataGrid.ClearSelection();
                                    output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(cPnr);

                                    infoMessage_lbl.Text = "Success! Customer with cPnr: " + cPnr + " is updated!";
                                }
                                else
                                {
                                    infoMessage_lbl.Text = "Incorrect inputs! Example: cPnr: \"911208-0131\" - Name: \"Mats Ucan\" - Mail: \"Erdogan@gmail.com\"";
                                }
                            }
                            else
                            {
                                infoMessage_lbl.Text = "Error! You have to fill out every field!";
                            }
                        }
                    }
                    else
                    {
                        infoMessage_lbl.Text = "Error! You have to select a Customer!";
                    }
                }
            }
            catch (HandleException err)
            {
                infoMessage_lbl.Text = err.Message;
            }
            updateCust_btn.Enabled = true;
        }

        //UPDATE RESERVATION
        private void updateRes_btn_Click(object sender, EventArgs e)
        {
            updateRes_btn.Enabled = false;

            try
            {
                //Check if cells are null
                if (output_dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];

                    if (row.Cells.Count > 0)
                    {
                        bool rowIsEmpty = true;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                rowIsEmpty = false;
                                break;
                            }
                        }

                        if (rowIsEmpty)
                            infoMessage_lbl.Text = "Select a non null row";

                        else {
                            string resID = row.Cells["resID"].Value.ToString();
                            string cPnr = row.Cells["cPnr"].Value.ToString();
                            string cabinNo = row.Cells["cabinNo"].Value.ToString();
                            string rWeek = row.Cells["rWeek"].Value.ToString();

                            if (cabinNo.Count(char.IsDigit) == 1 && cabinNo.Length == 1)
                            {
                                if (ctrl.UpdateReservation(resID, cPnr, cabinNo, rWeek)) // Bool check from DAL
                                {
                                    output_dataGrid.ClearSelection();
                                    getAllRes_btn.PerformClick();
                                    infoMessage_lbl.Text = "Success! Reservation with resID: " + resID + " is updated!";
                                }
                                else {
                                    infoMessage_lbl.Text = "Something went wrong. Make sure the Customer and cabin exists, and that the reservation date is available!";
                                }
                            }
                            else {
                                infoMessage_lbl.Text = "Something went wrong. Make sure the Customer and cabin exists, and that the reservation date is available!";
                            }
                            }
                        }
                    }
                    else
                    {
                        infoMessage_lbl.Text = "Error! You have to select a Reservation";
                    }
            }

            catch (HandleException err)
            {
                infoMessage_lbl.Text = err.errMessage;
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
            bool validEmail = false;
            try
            {
                //Mail validation
                try
                {
                    var addr = new System.Net.Mail.MailAddress(cMail);
                    validEmail = (addr.Address == cMail);
                }
                catch
                {
                    validEmail = false;
                }
                //Prevents empty fields
                if (cPnr != null && cPnr != "" && cName != null && cName != "" && cMail != null && cMail != "")
                {
                    //Validates cPnr and Name
                    if ((validEmail && cPnr.Count(char.IsDigit) == 10) && (cPnr[6] == '-') && (cName.Count(char.IsDigit) == 0) && cPnr.Length == 11)
                    {
                        if (ctrl.CreateCustomer(cPnr, cName, cMail))//Bool check from DAL
                        {
                            infoMessage_lbl.Text = "Success! Customer with cPnr: " + cPnr + " is created!";
                        }
                        output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(cPnr);
                    }
                    else
                    {
                        infoMessage_lbl.Text = "Incorrect inputs! Example: cPnr: \"911208-0131\" - Name: \"Mats Ucan\" - Mail: \"Erdogan@gmail.com\"";
                    }
                }
                else
                {
                    infoMessage_lbl.Text = "Error! You have to fill out every field!";
                }
            }
            catch (HandleException err)
            {
                infoMessage_lbl.Text = err.errMessage;
            }
            createCust_btn.Enabled = true;
        }

        //CREATE RESERVATION
        private void createRes_btn_Click(object sender, EventArgs e)
        {
            createRes_btn.Enabled = false;
            string cPnr = resCust_input.Text;
            int cabinNo = resCabin_comboBox.SelectedIndex + 1;
            int rWeek = (int)resWeek_input.Value;

            try
            {

                if (ctrl.CreateReservation(cPnr, cabinNo, rWeek))//Bool check form DAL
                {
                    output_dataGrid.DataSource = ctrl.GetReservationByCpnr(cPnr);
                    checkAvail_btn.Visible = true;
                    createRes_btn.Visible = false;
                    createRes_btn.Enabled = true;
                    infoMessage_lbl.Text = "Success! Reservation for cPnr: " + cPnr + " in Cabin: " + resCabin_comboBox.Text + " during week: " + rWeek + " is registred.";
                }
                else
                {
                    findAllCust_btn_Click(sender, e);
                    createRes_btn.Visible = false;

                }
            }
            catch (HandleException err)
            {
                infoMessage_lbl.Text = err.errMessage;

            }
            createRes_btn.Enabled = true;
        }

        //DELETE METHODS

        //DELETE CUSTOMER
        private void deleteCust_btn_Click(object sender, EventArgs e)
        {
            deleteCust_btn.Enabled = false;
            try
            {
                //Check if cells are null
                if (output_dataGrid.SelectedRows.Count > 0 && output_dataGrid.SelectedRows != null)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];

                    if (row.Cells.Count > 0)
                    {
                        bool rowIsEmpty = true;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                rowIsEmpty = false;
                                break;
                            }
                        }

                        if (rowIsEmpty)
                            infoMessage_lbl.Text = "Select a non null row";

                        else
                        {
                            string cPnr = row.Cells["cPnr"].Value.ToString();
                            ctrl.DeleteCustomer(cPnr);
                            output_dataGrid.ClearSelection();
                            getAllCust_btn.PerformClick();
                            infoMessage_lbl.Text = "Customer with cPnr : " + cPnr + " is deleted!";
                        }
                    }
                    else
                    {
                        infoMessage_lbl.Text = "You have to select a Customer!";
                    }
                }
            }
            catch (HandleException err)
            {
                MessageBox.Show(err.errMessage);

            }
            deleteCust_btn.Enabled = true;
        }

        //DELETE RESERVATION
        private void deleteRes_btn_Click(object sender, EventArgs e)
        {
            deleteRes_btn.Enabled = false;
            try
            {
                //Check if cells are null
                if (output_dataGrid.SelectedRows.Count > 0)
                {

                    DataGridViewRow row = output_dataGrid.SelectedRows[0];

                    if (row.Cells.Count > 0)
                    {
                        bool rowIsEmpty = true;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                rowIsEmpty = false;
                                break;
                            }
                        }

                        if (rowIsEmpty)
                            infoMessage_lbl.Text = "Select a non null row";
                        else
                        {
                            string resID = row.Cells["resID"].Value.ToString();

                            if (resID != null || resID != "")
                            {
                                ctrl.DeleteReservation(resID);
                                output_dataGrid.ClearSelection();
                                getAllRes_btn.PerformClick();
                                infoMessage_lbl.Text = "Reservation with resID : " + resID + " is deleted!";
                            }
                        }
                    }
                }
            }

            catch (HandleException err)
            {
                MessageBox.Show(err.errMessage);
            }
            deleteRes_btn.Enabled = true;

        }

    }
}

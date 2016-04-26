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
           output_dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            output_dataGrid.SelectionChanged += new EventHandler((s, e) =>
            {

            });
            output_dataGrid.MultiSelect = false;

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

        }


        private void findCust_btn_Click(object sender, EventArgs e)
        {
            output_dataGrid.DataSource = null;
            output_dataGrid.Rows.Clear();
            DataTable dt = ctrl.GetCustomerByCpnr(findCust_input.Text);
            output_dataGrid.DataSource = ctrl.GetCustomerByCpnr(findCust_input.Text).DefaultView;
            if (output_dataGrid.DataSource != null)
            {
                output_dataGrid.DataSource = null;
                output_dataGrid.Rows.Clear();
                output_dataGrid.Columns[0].ReadOnly = true;
                output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                updateCust_btn.Visible = true;
                deleteCust_btn.Visible = true;
                updateRes_btn.Visible = false;
                deleteRes_btn.Visible = false;
                
            }
        }

        private void updateCust_btn_Click(object sender, EventArgs e)
        {
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
                    System.Windows.Forms.MessageBox.Show("Customer with cPnr: "+ cPnr +" is updated!");
                }
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("You have to select a Customer!");

            }
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

                if (output_dataGrid.DataSource != null)
                {
                    
                    output_dataGrid.Columns[0].ReadOnly = true;
                    output_dataGrid.Columns[0].DefaultCellStyle.ForeColor = Color.LightBlue;
                    updateRes_btn.Visible = true;
                    deleteCust_btn.Visible = false;
                    updateCust_btn.Visible = false;
                    deleteRes_btn.Visible = true;
                    output_dataGrid.DataSource = null;
                    output_dataGrid.Rows.Clear();
                }
            }

            else if (findRes_comboBox.SelectedIndex == 1)
            {
                string cPnr = findRes_input.Text;
                output_dataGrid.DataSource = ctrl.GetReservationByCpnr(cPnr);
            }
        }

        private void checkAvail_btn_Click(object sender, EventArgs e)
        {
            string cPnr = null;
            int cabinNo = 0;
            int rWeek = 0;
            if (resCust_input.Text == null || resCust_input.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("You have to select a customer!");

            }
           else {
                cPnr = resCust_input.Text;
                cabinNo = Convert.ToInt32(resCabin_comboBox.SelectedItem.ToString());
                rWeek = (int)resWeek_input.Value;

                if (ctrl.CheckReservation(cabinNo, rWeek))
                {
                    checkAvail_btn.Visible = true;
                    createRes_btn.Visible = true;

                }
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

        private void findAllCust_btn_Click(object sender, EventArgs e)
        {
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
        }

        private void deleteCust_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (output_dataGrid.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = output_dataGrid.SelectedRows[0];
                    string cPnr = row.Cells["cPnr"].Value.ToString();
                   

                    ctrl.DeleteCustomer(cPnr);
                    output_dataGrid.ClearSelection();
                    findAllCust_btn.PerformClick();
                    System.Windows.Forms.MessageBox.Show("Customer with cPnr : "+ cPnr + " is deleted!");

                }
            }

            catch
            {
                System.Windows.Forms.MessageBox.Show("You have to select a Customer!");

            }
        }

        private void updateRes_btn_Click(object sender, EventArgs e)
        {
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

        }

        private void deleteRes_btn_Click(object sender, EventArgs e)
        {
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

        }

        private void findAllRes_btn_Click(object sender, EventArgs e)
        {
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

        }
    }
}

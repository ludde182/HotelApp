using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.DAL;
using HotelApp.Controller;
using System.Data;
using HotelApp;
using System.Net;
using HotelApp.Utility;


namespace HotelApp.Utility
{
    class Utility
    {

        public Utility()
        {
            Controller.Controller ctrl = new Controller.Controller();
            
        }
        

        

        public void createCustomer() {
        }

        public void updateCustomer(DataTable dt) {
            foreach (DataRow row in dt.Rows)
            {
                var cPnr = row[0];
                var cName = row[1];
                var cPhone = row[2];
                Console.WriteLine(cPnr.ToString() + cName.ToString() + cPhone.ToString());
            }


        }

     /*   public void regCust (string cPnr, string cName, string cMail)
        {
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
                    form.output_dataGrid.DataSource = ctrl.GetAllCustomers();
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

        }*/


    }
}

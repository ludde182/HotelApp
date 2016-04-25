using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.DAL;
using HotelApp.Controller;
using System.Data;

namespace HotelApp
{
    class Utility
    {
        private Controller.Controller ctrl = new Controller.Controller();

        public void searchCustomer(string s) {
            ctrl.GetCustomerByCpnr(s);
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


    }
}

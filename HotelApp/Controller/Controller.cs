using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelApp;
using HotelApp.DAL;
using HotelApp.Model;

namespace HotelApp.Controller
{

    class Controller
    {
        private DAL.DAL dal;

        public Controller()
        {
            dal = new DAL.DAL();
        }

        public SqlDataAdapter GetAllCustomers()
        {
            return dal.GetAllCustomers();
        }

        public SqlDataAdapter GetCustomerByCpnr(string cPnr)
        {
            return dal.GetCustomerByCpnr(cPnr);

        }

        public bool CreateCustomer(Customer c)
        {

            return dal.CreateCustomer(c);

        }

        public bool CreateReservation(string cPnr, int cabinNo, int week)
        {

            return dal.CreateReservation(cPnr, cabinNo, week);

        }

        public SqlDataAdapter GetReservationByCpnr(string cPnr)
        {
            return dal.GetReservationByCpnr(cPnr);
        }

        public SqlDataAdapter GetReservationByResId(string resId)
        {
            return dal.GetReservationByResId(resId);
        }
    }
}
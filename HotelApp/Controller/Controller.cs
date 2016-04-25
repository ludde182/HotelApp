using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HotelApp.DAL;
using HotelApp;
namespace HotelApp.Controller
{
    class Controller
    {

        private DAL.DAL dal;
        public Controller()
        {
            dal = new DAL.DAL();
        }

        public DataTable GetAllCustomers()
        {
            return dal.GetAllCustomers();
        }

        public DataTable GetCustomerByCpnr(string cPnr)
        {
            return dal.GetCustomerByCpnr(cPnr);

        }

        public bool CreateCustomer(string cPnr, string cName, string cMail)
        {

            return dal.CreateCustomer(cPnr, cName, cMail);

        }

        public bool CreateReservation(string cPnr, int cabinNo, int week)
        {

            return dal.CreateReservation(cPnr, cabinNo, week);

        }

        public DataTable GetReservationByCpnr(string cPnr)
        {
            return dal.GetReservationByCpnr(cPnr);
        }

        public DataTable GetReservationByResId(string resID)
        {
            return dal.GetReservationByResId(resID);
        }
        public bool CheckReservation(int cabinNo, int rWeek)
        {
            return dal.CheckReservation(cabinNo, rWeek);
        }


    }

}


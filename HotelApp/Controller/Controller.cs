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

        //GET ALL METHODS

        public DataTable GetAllCustomers()
        {
            return dal.GetAllCustomers();
        }

        public DataTable GetAllReservations()
        {
            return dal.GetAllReservations();
        }

        // GET BY ID METHODS

        public DataTable GetCustomerByCpnr(string cPnr)
        {
            return dal.GetCustomerByCpnr(cPnr);
        }

        public DataTable GetReservationByResId(string resID)
        {
            return dal.GetReservationByResId(resID);
        }

        public DataTable GetReservationByCpnr(string cPnr)
        {
            return dal.GetReservationByCpnr(cPnr);
        }

        //CHECK AVAILABILITY METHOD

        public bool CheckReservation(int cabinNo, int rWeek)
        {
            return dal.CheckReservation(cabinNo, rWeek);
        }

        //UPDATE METHODS

        public bool UpdateCustomer(String cPnr, String cName, String cMail)
        {
            return dal.UpdateCustomer(cPnr, cName, cMail);
        }

        public bool UpdateReservation(String resID, String cPnr, String cabinNo, String rWeek)
        {
            return dal.UpdateReservation(resID, cPnr, cabinNo, rWeek);
        }

        //CREATE METHODS

        public bool CreateCustomer(string cPnr, string cName, string cMail)
        {
            return dal.CreateCustomer(cPnr, cName, cMail);
        }

        public bool CreateReservation(string cPnr, int cabinNo, int week)
        {
            return dal.CreateReservation(cPnr, cabinNo, week);
        }

        //DELETE MeTHODS      

        public bool DeleteCustomer(string cPnr)
        {
            return dal.DeleteCustomer(cPnr);
        }

        public bool DeleteReservation(string resID)
        {
            return dal.DeleteReservation(resID);
        }

    }

}


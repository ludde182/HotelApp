using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelApp.DAL;
using System.Data;
using HotelApp.Exception;

namespace HotelApp.DAL
{

    class DAL
    {
        SqlConnection con = new SqlConnection();

        public DAL()
        {
            con.ConnectionString = "user id=root;" +
                                                      "password=root;server=DESKTOP-54MVI8J\\SQLEXPRESS;" +
                                                      "Trusted_Connection=yes;" +
                                                      "database=test; " +
                                                      "connection timeout=30";
        }

        //GET ALL METHODS       

        //GET ALL CUSTOMERS
        public DataTable GetAllCustomers()
        {
            try
            {
                con.Open();
                string query = ("select * from Customer");
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                da.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                con.Close();
                throw new HandleException("Database Error, please contact developer.");
            }
        }

        //GET ALL RESERVATIONS
        public DataTable GetAllReservations()
        {
            try
            {
                con.Open();
                string query = ("select * from Reservation");
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                da.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                con.Close();
                throw new HandleException("Database Error, please contact developer.");
            }
        }

        //GET BY ID METHODS

        //GET CUSTOMER BY cPnr
        public DataTable GetCustomerByCpnr(string cPnr)
        {
            try
            {
                con.Open();
                string query = ("select* from Customer where cPnr = @cPnr");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                con.Close();
                throw new HandleException("Database Error, please contact developer.");
            }
        }

        //GET RESERVATION BY resID
        public DataTable GetReservationByResId(string resID)
        {
            try
            {
                con.Open();
                string query = ("Select * from reservation where resID = @resID");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@resID", resID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                con.Close();
                throw new HandleException("Database Error, please contact developer.");
            }
        }

        //GET RESERVATION BY cPnr
        public DataTable GetReservationByCpnr(string cPnr)
        {
            try
            {
                con.Open();
                string query = ("Select * from reservation where cPnr = @cPnr");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                con.Close();
                return table;
            }
            catch
            {
                con.Close();
                throw new HandleException("Database Error, please contact developer.");
            }
        }

        //CHECK AVAILABILITY
        public bool CheckReservation(int cabinNo, int rWeek)
        {
            bool b = false;
            try
            {
                con.Open();
                string query = ("SELECT * FROM Reservation WHERE cabinNo = @cabinNo AND rWeek = @rWeek ");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cabinNo", cabinNo);
                cmd.Parameters.AddWithValue("@rWeek", rWeek);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count == 0) //Makes sure the option is available
                    b = true;
                else if (table.Rows.Count > 0)
                {
                    b = false;
                }
                con.Close();
            }

            catch
            {
                b = false;
                con.Close();
                throw new HandleException("Database Error, please contact developer.");
            }
            return b;
        }

        //UPDATE METHODS

        //UPDATE CUSTOMER
        public bool UpdateCustomer(String cPnr, String cName, String cMail)
        {

            bool b = false;
            try
            {
                con.Open();
                string query = ("UPDATE Customer SET cName = @cName, cMail = @cMail WHERE cPnr = @cPnr");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                cmd.Parameters.AddWithValue("@cName", cName);
                cmd.Parameters.AddWithValue("@cMail", cMail);
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }

            catch
            {
                b = false;
                con.Close();
                throw new HandleException("You have to select a Customer!");
            }
            return b;
        }

        //UPDATE RESERVATION 
        public bool UpdateReservation(String resID, String cPnr, String cabinNo, String rWeek)
        {

            bool b = false;
            try
            {

                con.Open();
                string query = ("select* from Customer where cPnr = @cPnr");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                con.Close();

                if (table.Rows.Count > 0) //Checks if customer exists
                {

                    con.Open();
                    string query1 = ("SELECT * FROM Reservation WHERE cabinNo = @cabinNo AND rWeek = @rWeek ");
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("@cabinNo", cabinNo);
                    cmd1.Parameters.AddWithValue("@rWeek", rWeek);
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    DataTable table1 = new DataTable();
                    da1.Fill(table1);

                    if (table1.Rows.Count == 0) //Makes sure the reservation option is available
                    {
                        string query2 = ("UPDATE Reservation SET cPnr = @cPnr, cabinNo = @cabinNo, rWeek = @rWeek WHERE resID = @resID");

                        SqlCommand cmd2 = new SqlCommand(query2, con);
                        cmd2.Parameters.AddWithValue("@resID", resID);
                        cmd2.Parameters.AddWithValue("@cPnr", cPnr);
                        cmd2.Parameters.AddWithValue("@cabinNo", cabinNo);
                        cmd2.Parameters.AddWithValue("@rWeek", rWeek);
                        cmd2.ExecuteReader();
                        b = true;
                        con.Close();
                    }
                }
                else
                {
                    b = false;
                    con.Close();
                    throw new HandleException("Something went wrong. Make sure the Customer exists and that the reservation date is available.");
                }
            }
            catch
            {
                b = false;
                con.Close();
                throw new HandleException("Something went wrong. Make sure the Customer and cabin exists, and that the reservation date is available!");
            }
            con.Close();
            return b;
        }

        //CREATE METHODS

        //CREATE CUSTOMER
        public bool CreateCustomer(String cPnr, String cName, String cMail)
        {

            bool b = false;
            try
            {
                con.Open();
                string query = ("insert into Customer values (@cPnr, @cName, @cMail) ");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                cmd.Parameters.AddWithValue("@cName", cName);
                cmd.Parameters.AddWithValue("@cMail", cMail);
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }
            catch
            {
                b = false;
                con.Close();
                throw new HandleException("The Customer already exists.");
            }
            return b;
        }

        //CREATE RESERVATION
        public bool CreateReservation(string cPnr, int cabinNo, int week)
        {
            con.Open();
            bool b = true;
            try
            {
                string query = ("insert into Reservation(cPnr, cabinNo, rWeek) values (@cPnr, @cabinNo, @week) ");

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                cmd.Parameters.AddWithValue("@cabinNo", cabinNo);
                cmd.Parameters.AddWithValue("@week", week);
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }

            catch
            {
                b = false;
                con.Close();
                throw new HandleException("Reservation didn't go trough. Make sure the Customer exists in the database!");

            }
            return b;
        }

        //DELETE METHODS

        //DELETE CUSTOMER
        public bool DeleteCustomer(string cPnr)
        {
            bool b = true;
            try
            {
                con.Open();
                string query = ("DELETE FROM Customer WHERE cPnr =  @cPnr");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }

            catch (SqlException sqlEx)
            {
                b = false;
                con.Close();
                sqlEx.Message.StartsWith("The INSERT statement conflicted");
                throw new HandleException("Database error" + sqlEx.ToString());

            }
            return b;
        }

        //DELETE RESERVATION
        public bool DeleteReservation(string resID)
        {
            bool b = true;
            try
            {
                con.Open();
                string query = ("DELETE FROM Reservation WHERE resID =  @resID");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }

            catch (SqlException sqlEx)
            {
                b = false;
                con.Close();
                sqlEx.Message.StartsWith("The INSERT statement conflicted");
                throw new HandleException("Database error" + sqlEx.ToString());

            }
            return b;
        }
    }
}
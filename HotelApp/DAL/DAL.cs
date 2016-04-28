using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelApp.DAL;
using System.Data;

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
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                con.Close();
                throw sqlEx;
                
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
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                con.Close();
                throw sqlEx;
            }
        }

        //FIND BY ID METHODS

        //FIND CUSTOMER BY cPnr
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
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                con.Close();
                throw sqlEx;
            }
        }

        //FIND RESERVATION BY resID
        public DataTable GetReservationByResId(string resID) //ERROR när man skriver in ÖVER 10 tecken som resID
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
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                con.Close();
                throw sqlEx;
            }
        }


        //FIND RESERVATION BY cPnr
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
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                con.Close();
                throw sqlEx;
            }
        }

        //CHECK AVAILABILITY
        public bool CheckReservation(int cabinNo, int rWeek)
        {
            bool b = false;
            try
            {
                con.Open();
                string query = ("SELECT * FROM Reservation WHERE cabinNo = @cabinNo AND rWeek = @rWeek  ");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cabinNo", cabinNo);
                cmd.Parameters.AddWithValue("@rWeek", rWeek);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);
                if (table.Rows.Count == 0)
                    b = true;
                else if (table.Rows.Count > 0)
                {
                    System.Windows.Forms.MessageBox.Show("The option isn't available!");
                    b = false;
                }

                con.Close();
            }

            catch (SqlException sqlEx)
            {
                sqlEx.Message.StartsWith("The INSERT statement conflicted");
                System.Windows.Forms.MessageBox.Show("Database error" + sqlEx.ToString());
                b = false;
                con.Close();
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

            catch (SqlException sqlEx)
            {
                sqlEx.Message.StartsWith("");
                System.Windows.Forms.MessageBox.Show("You have to select a Customer!");
                if (sqlEx.Message.StartsWith(""))
                {
                    b = false;
                }
                con.Close();
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
                string query = ("UPDATE Reservation SET cPnr = @cPnr, cabinNo = @cabinNO, rWeek = @rWeek WHERE resID = @cPnr");
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@resID", resID);
                cmd.Parameters.AddWithValue("@cPnr", cPnr);
                cmd.Parameters.AddWithValue("@cabinNo", cabinNo);
                cmd.Parameters.AddWithValue("@rWeek", rWeek);
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }

            catch (SqlException sqlEx)
            {
                sqlEx.Message.StartsWith("");
                System.Windows.Forms.MessageBox.Show("Something went wrong. Make sure the Customer exists and that the reservation date is available!");
                if (sqlEx.Message.StartsWith(""))
                {
                    b = false;
                }
                con.Close();
            }
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

            catch (SqlException sqlEx)
            {
                sqlEx.Message.StartsWith("");
                System.Windows.Forms.MessageBox.Show("The Customer already exists.");
                if (sqlEx.Message.StartsWith(""))
                {
                    b = false;
                }
                con.Close();
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

            catch (SqlException sqlEx)
            {
                sqlEx.Message.StartsWith("The INSERT statement conflicted");

                System.Windows.Forms.MessageBox.Show("Reservation didn't go trough. Make sure the Customer exists in the database!");
                b = false;
                con.Close();
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
                sqlEx.Message.StartsWith("The INSERT statement conflicted");
                System.Windows.Forms.MessageBox.Show("Database error" + sqlEx.ToString());
                b = false;
                con.Close();
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
                sqlEx.Message.StartsWith("The INSERT statement conflicted");
                System.Windows.Forms.MessageBox.Show("Database error" + sqlEx.ToString());
                b = false;
                con.Close();
            }
            return b;
        }
    }
}
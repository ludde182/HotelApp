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
            con.ConnectionString = "user id=sa;" +
                                                      "password=root;server=localhost;" +
                                                      "Trusted_Connection=yes;" +
                                                      "database=database; " +
                                                      "connection timeout=30";
        }

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
                //  SqlParameter param = new SqlParameter();
                //  param.Value = "MIt värder";
                //  param.ParameterName = "@cPnr";
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
                System.Windows.Forms.MessageBox.Show("Database error" + sqlEx.ToString());
                b = false;
                con.Close();
            }
            return b;
        }

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
                throw sqlEx;
            }
        }

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
                throw sqlEx;
            }
        }

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
                throw sqlEx;
            }
        }

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
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }

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
                //  SqlParameter param = new SqlParameter();
                //  param.Value = "MIt värder";
                //  param.ParameterName = "@cPnr";
                cmd.ExecuteReader();
                b = true;
                con.Close();
            }

            catch (SqlException sqlEx)
            {
                sqlEx.Message.StartsWith("");
                System.Windows.Forms.MessageBox.Show("You can't change the cPnr.");
                if (sqlEx.Message.StartsWith(""))
                {
                    b = false;
                }
                con.Close();
            }
            return b;
        }

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
                var result = cmd.ExecuteNonQuery();
                if (result < 0)
                    b = true;
                else if (result > 0)
                    b = false;

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
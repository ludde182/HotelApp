using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HotelApp.DAL;
using HotelApp.Model;


namespace HotelApp.DAL
{

    class DAL
    {
        SqlConnection con = new SqlConnection();


        public DAL()
        {
            con.ConnectionString = "user id=sa;" +
                                                      "password=root;server=DESKTOP-LAMR8JS;" +
                                                      "Trusted_Connection=yes;" +
                                                      "database=database; " +
                                                      "connection timeout=30";
        }

        public bool CreateCustomer(Customer c)
        {

            bool b = false;
            try
            {
                con.Open();
                string query = ("insert into Customer values ('" + c.cPnr + "', '" + c.cName + "', '" + c.cMail + "') ");
                SqlCommand cmd = new SqlCommand(query, con);
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
                string query = ("insert into Reservation values  ('" + cPnr + "', '" + cabinNo + "', '" + week + "') ");

                SqlCommand cmd = new SqlCommand(query, con);
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

        public SqlDataAdapter GetAllCustomers()
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from Customer", con);
                con.Close();
                return da;
            }
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }

        public SqlDataAdapter GetCustomerByCpnr(string cpnr)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from customer where cPnr = '" + cpnr + "'", con);
                con.Close();
                return da;
            }
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }

        public SqlDataAdapter GetReservationByCpnr(string cpnr)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from reservation where cPnr = '" + cpnr + "'", con);
                con.Close();
                return da;
            }
            catch (SqlException sqlEx)
            {
                System.Windows.Forms.MessageBox.Show("Database error:" + sqlEx.ToString());
                throw sqlEx;
            }
        }

        public SqlDataAdapter GetReservationByResId(string resId)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from reservation where resId = '" + resId + "'", con);
                con.Close();
                return da;
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
                string query = "DELETE FROM Customer WHERE cPnr =  '" + cPnr + "'";

                SqlCommand cmd = new SqlCommand(query, con);
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
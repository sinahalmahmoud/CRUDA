using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace connection
{
    class connect
    {
        public connect() { }
        public void connectdemoshow(string sql, string country)
        {
            string connectionstring = @"data source=DESKTOP-KT5D1OQ\SQLEXPRESS; database=TelerikAcademy99; integrated security=SSPI;trustservercertificate=true ";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();
            SqlCommand sqlcommand = new SqlCommand(sql, conn);
            SqlDataReader sqlreader;
            sqlcommand.Parameters.AddWithValue("@country", country);
            sqlreader = sqlcommand.ExecuteReader();
            while (sqlreader.Read())
            {
                Console.WriteLine("OrderID" + sqlreader[0] + " " +
                                   "EmployeeID " + sqlreader[1] + " " +
                                   "ShipCountry " + sqlreader[1] + " " +
                                   "UnitPrice " + sqlreader[1] + " " +
                                   "Quantity " + sqlreader[1] + " " +
                                   "Discount " + sqlreader[1] + " ");


            }

            conn.Close();
            Console.WriteLine("DONE");
            Console.ReadLine();

        }
        public void connectdemoupdate(string sql, int naddress, int emid)
        {

            string connectionstring = @"data source=DESKTOP-KT5D1OQ\SQLEXPRESS; database=TelerikAcademy99; integrated security=SSPI;trustservercertificate=true ";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlCommand sqlcommand = new SqlCommand(sql, conn);

            sqlcommand.Parameters.AddWithValue("@naddress", naddress);
            sqlcommand.Parameters.AddWithValue("@emid", emid);


            int rows = sqlcommand.ExecuteNonQuery();
            {
                Console.WriteLine(rows);

                conn.Close();
                Console.WriteLine("DONE");
                Console.ReadLine();
            }

        }
        public void connectdemodelete(string sql, string customerid)
        {

            string connectionstring = @"data source=DESKTOP-KT5D1OQ\SQLEXPRESS; database=TelerikAcademy99; integrated security=SSPI;trustservercertificate=true ";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlCommand sqlcommand = new SqlCommand(sql, conn);

            sqlcommand.Parameters.AddWithValue("@customerid", customerid);

            int rows = sqlcommand.ExecuteNonQuery();
            {
                Console.WriteLine(rows);

                conn.Close();
                Console.WriteLine("DONE");
                Console.ReadLine();
            }
        }
    
         public void connectdemoadd(string sql, string customerid, string companyname, string contactname, string contacttitle, string address, string city, string region, string postalcode, string country, string phone, string fax)
          {

            string connectionstring = @"data source=DESKTOP-KT5D1OQ\SQLEXPRESS; database=TelerikAcademy99; integrated security=SSPI;trustservercertificate=true ";
            SqlConnection conn = new SqlConnection(connectionstring);
            conn.Open();

            SqlCommand sqlcommand = new SqlCommand(sql, conn);

            sqlcommand.Parameters.AddWithValue("@customerid", customerid );
            sqlcommand.Parameters.AddWithValue("@companyname", companyname);
            sqlcommand.Parameters.AddWithValue("@contactname", contactname);
            sqlcommand.Parameters.AddWithValue("@contacttitle", contacttitle);
            sqlcommand.Parameters.AddWithValue("@address", address);
            sqlcommand.Parameters.AddWithValue("@city", city);
            sqlcommand.Parameters.AddWithValue("@region", region);
            sqlcommand.Parameters.AddWithValue("@postalcode", postalcode);
            sqlcommand.Parameters.AddWithValue("@country", country);
            sqlcommand.Parameters.AddWithValue("@phone", phone);
            sqlcommand.Parameters.AddWithValue("@fax", fax);


            int rows = sqlcommand.ExecuteNonQuery();

    {
        Console.WriteLine(rows);

        conn.Close();
        Console.WriteLine("DONE");
        Console.ReadLine();
    }
}

}}



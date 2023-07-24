using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21CreateCustomerTableUsingDB
{
    public class CustomerInfo
    {
       public  string connString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CustomerDetails;Integrated Security=True";

        //Create => C
        public void InsertData(CustomerClass c)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            try
            {
                Console.WriteLine("Connection can be established successfully!");                 
                string insertQuery = "Insert into CustomerDB(Customer_Name,PhoneNumber,Address,Country,Salary,Pincode)" +
                    "VALUES('" +c.Customer_Name + "','" +c.PhoneNumber + "','" +c.Address + "','" +c.Country + "','"+c.Salary + "','"+c.Pincode + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine($"{n} row(s) inserted successfully!....");
                           }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        } //Retrive => R
        public void RetriveData()
        {
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                string displayQuery = "select * from CustomerDB";
                SqlCommand cmd = new SqlCommand(displayQuery, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("CustomerId : " + dr.GetValue(0).ToString());
                    Console.WriteLine("Customer_Name : " + dr.GetValue(1).ToString());
                    Console.WriteLine("PhoneNumber : " + dr.GetValue(2).ToString());
                    Console.WriteLine("Address : " + dr.GetValue(3).ToString());
                    Console.WriteLine("Country : " + dr.GetValue(4).ToString());
                    Console.WriteLine("Salary : " + dr.GetValue(5).ToString());
                    Console.WriteLine("Pincode : " + dr.GetValue(6).ToString());
                    Console.WriteLine("");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Update => U
        public void UpdateData(CustomerClass c)
        {
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();               
                string updateQuery = "update CustomerDB set Customer_Name ='" + c.Customer_Name + "' where CustomerId = '" +c.CustomerId + "'";
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine($"{n} row(s) id update..");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Delete =>D
        public void DeleteData(CustomerClass c)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string deleteQuery = "delete from CustomerDB where CustomerId = '" + c.CustomerId + "'";
                SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine($"{n} row(s) Deleted Successfully..");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

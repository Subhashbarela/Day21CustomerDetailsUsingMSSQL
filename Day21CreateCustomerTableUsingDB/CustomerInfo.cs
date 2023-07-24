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
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            try
            {
                Console.WriteLine("Connection can be established successfully!");               
                
                string insertQuery = "Insert into CustomerDB(Customer_Name,PhoneNumber,Address,Country,Salary,Pincode)" +
                    "VALUES('" +c.Customer_Name + "','" +c.PhoneNumber + "','" +c.Address + "','" +c.Country + "','"+c.Salary + "','"+c.Pincode + "')";
                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                int n = cmd.ExecuteNonQuery();
                Console.WriteLine($"{n} row(s) inserted successfully!....");
                           }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }       

    }
}

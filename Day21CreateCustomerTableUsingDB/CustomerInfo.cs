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
                string Customer_Name = "subhash";
                long PhoneNumber = 9797979792;
                string Address = "Abc12 ";
                string Country = "INDIA";
                int Salary = 47756757;
                int Pincode = 466465;
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
        //Retrive => R
        public void RetriveData()
        {
            SqlConnection conn = new SqlConnection( connString);

            try
            {
                conn.Open();
                string displayQuery = "select * from Employee";
                SqlCommand cmd = new SqlCommand(displayQuery, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Emp_Name : " + dr.GetValue(0).ToString());
                    Console.WriteLine("Gender : " + dr.GetValue(1).ToString());
                    Console.WriteLine("Email : " + dr.GetValue(2).ToString());
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
        public void UpdateData()
        {
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                conn.Open();
                Console.WriteLine("Enter the Emp Id that you would like to update :");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the namev of employee to update :");
                string name = Console.ReadLine();
                string updateQuery = "update Employee set EmpName ='" + name + "' where id = '" + id + "'";
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
        public void DeleteData()
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {                
                Console.WriteLine("Enter the Emp Id th                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        at you would like to update :");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the namev of employee to update :");
                string name = Console.ReadLine();
                string updateQuery = "update Employee set EmpName ='" + name + "' where id = '" + id + "'";
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21CreateCustomerTableUsingDB
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerClass customer = new CustomerClass();           
            customer.Customer_Name = "Rajvir";
            customer.PhoneNumber = 8654357756;
            customer.Address = "Rajstan";
            customer.Country = "India";
            customer.Salary = 4535353;
            customer.Pincode = 543435;
            Console.WriteLine("1: Insert Data To Database \n2: Retrive Data From db \n3: Update Data");
            Console.WriteLine("insert the choice");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        CustomerInfo info = new CustomerInfo();
                        info.InsertData(customer);
                        break;
                    } 
                case 2:
                    {
                        CustomerInfo info = new CustomerInfo();                       
                        info.RetriveData();
                        break;
                    } 
                case 3:
                    {
                        CustomerClass c = new CustomerClass();
                        CustomerInfo info = new CustomerInfo();
                        c.Customer_Name = "Summit";
                        c.CustomerId = 2;
                        info.UpdateData(c);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert valid input");
                        break;
                    }
            }            
            
        }
    }
}

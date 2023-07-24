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
           
            Console.WriteLine("1: Insert Data To Database \n2: Retrive Data From db \n3: Update Data \n4: Delete Data");
            Console.WriteLine("insert the choice");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        CustomerClass customer = new CustomerClass();
                        customer.Customer_Name = "Rahul";
                        customer.PhoneNumber = 6743002344;
                        customer.Address = "MH";
                        customer.Country = "India";
                        customer.Salary = 540000;
                        customer.Pincode = 425321;
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
                case 4:
                    {
                        CustomerClass c = new CustomerClass();
                        CustomerInfo info = new CustomerInfo();                        
                        c.CustomerId = 5;
                        info.DeleteData(c);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert valid input");
                        break;
                    }
            }
            Console.ReadLine();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class CustomerAdministration
    {
        private static List<Customer> CustomerList = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
          CustomerList.Add(customer);
        }


        public static void FindCustomer(string name)
        {
            Customer c = null;
            
                c = CustomerList.Find(c => c.Name == name);
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Email} {c.Address}");
            }

        }

        public static void UpdateCustomer(int id, Customer customerTag)
        {
            foreach (Customer customer in CustomerList)
            {
                if (customerTag.Id == id)
                {
                    id = customerTag.Id;
                    customer.Name = customerTag.Name;
                    customer.Address = customerTag.Address;
                    customer.Email = customerTag.Email;
                }
            }

            
        }

        public static Customer RemoveCustomer(int id)
        {
            foreach(Customer customer in CustomerList)
            {

                if (customer.Id == id)
                {
                    CustomerList.Remove(customer);
                    return customer;
                }
            }

            return null;
        }

        public static void PrintAllCustomers()
        {
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine(customer);
            }
        }

    }


    

}

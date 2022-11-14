using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{

    public class Customer
    {
        
        public static int nextId = 1;
      
        public Customer(string name, string address, string email)
        {
            Id = nextId++;
            Name = name;
            Address = address;
            Email = email;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address{ get; set; }
      
        public override string ToString()
        {
            return Name + ", " + Address + ", " + " CustomerID: " + Id;
        }

    }


}

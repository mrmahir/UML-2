using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Ordre
    {
        private Pizza _item;
        private Customer _customer;
       


        public Ordre(Pizza item, Customer customer)
        {
           _item = item;
           _customer = customer;

        }
        
        public Pizza Item
        {
            get { return _item; }
            set { _item = value; }
        }
        
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }
        
        
        public override string ToString()
        {
            return "Bestilling " + "\n" + Item + "\n" + "Kunde: " + Customer;
        }

        public double CalculateTotalPrice()
        {
            return Item.Price * 1.25 + 40;
        }

    }

}



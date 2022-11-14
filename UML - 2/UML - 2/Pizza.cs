using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{ 
    public class Pizza
    {
       private string _name;
       private double _price;
       private string _description;
       private int _Id;
       private static int idCounter = 0;
        public Pizza(string name, double price, string description)
        {
            _name = name;
            _price = price;
            _description = description;
            _Id = idCounter++;
        }


        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public override string ToString()
        {
            return "Ret: " + _name + " " + _description + " " + _price + ",-" + "Nummer" + ID;
        }

    }

   
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PizzaAdministration
    {
        private static Dictionary<int, Pizza> PizzaList = new Dictionary<int, Pizza>();

        public int Count
        {
            get { return PizzaList.Count; }
        }

        public static void AddPizza(Pizza pizza)
        {
            if (PizzaList.ContainsKey(pizza.ID))
            {
                Console.WriteLine($"{pizza} exists already");
            }
            else
            {
                PizzaList.Add(pizza.ID, pizza);
                Console.WriteLine($"{pizza} added");
            }
        }
        public static void FindPizza(int id)
        {
            if (PizzaList.ContainsKey(id))
            {
                Console.WriteLine(PizzaList[id]);
            }
            else
            {
                Console.WriteLine("There is no such pizza");
            }
        }
        public static void UpdatePizza(int id, string NewName, string NewDescription, int NewPrice)
        {
            PizzaList[id].Price = NewPrice;
            PizzaList[id].Name = NewName;
            PizzaList[id].Description = NewDescription;
        }
        public static void DeletePizza(int id)
        {
            if (PizzaList.ContainsKey(id))
            {
                Console.WriteLine($"Pizza ID:{id}, has been removed");
                PizzaList.Remove(id);
            }
            else
            {
                Console.WriteLine("There is no such pizza");
            }
        }

        public static void PrintAllMenu()
        {
            foreach (var pizza in PizzaList)
            {
                Console.WriteLine(pizza);
            }
        }
    }
}

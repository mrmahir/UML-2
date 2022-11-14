using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{

    class Store
{
    public static void Start()
    {
        Pizza margerita = new Pizza("Margerita", 70.0, "Med tomatsauce og ost");
        Customer customer1 = new Customer("Henrik", "Herregårdvej 72", "mamamsm@gamil.com");
        Ordre ordre1 = new Ordre(margerita, customer1);

        Pizza kebabPizza = new Pizza("Kebab Pizza", 89.0, "Med tomatsauce, ost, kebab, salat og dressing");
        Customer customer2 = new Customer("Jakob", "Nielsen Nielsenvej 52", "jakob4100@gamil.com");
        Ordre ordre2 = new Ordre(kebabPizza, customer2);

        Pizza vesuvio = new Pizza("Vesuvio", 75, "Med ost, tomatsauce og kalkuntopping");
        Customer customer3 = new Customer("Lars Larsen", "Larsenvej 12", "larslarsen@gmail.com");


        CustomerAdministration.AddCustomer(customer1);
        CustomerAdministration.AddCustomer(customer2);
        CustomerAdministration.AddCustomer(customer3);

        CustomerAdministration.PrintAllCustomers();

        Console.WriteLine("Update after value update");

        customer1.Id = 4;
        customer1.Email = "nyemailkunde1@gmail.com";
        customer1.Address = "nyaddressevej 123";
        customer1.Name = "Nytnavnsen";

        customer2.Id = 9;
        customer2.Email = "nyemailkunde1@gmail.com";
        customer2.Address = "nyaddressevej 123";
        customer2.Name = "Nytnavnsen";

        customer3.Id = 2;
        customer3.Email = "nyemailkunde1@gmail.com";
        customer3.Address = "nyaddressevej 123";
        customer3.Name = "Nytnavnsen";

        CustomerAdministration.UpdateCustomer(1, customer1);
        CustomerAdministration.UpdateCustomer(2, customer2);
        CustomerAdministration.UpdateCustomer(3, customer3);

        CustomerAdministration.PrintAllCustomers();

        Console.WriteLine("Update after removal");

        CustomerAdministration.RemoveCustomer(4);
        CustomerAdministration.PrintAllCustomers();

        Console.WriteLine("Search");

        
        CustomerAdministration.FindCustomer(customer1.Name);

        Console.WriteLine("Adding Pizza");

        PizzaAdministration.AddPizza(kebabPizza);
        PizzaAdministration.AddPizza(vesuvio);
        PizzaAdministration.PrintAllMenu();

        Console.WriteLine("Updating Pizza");

        PizzaAdministration.UpdatePizza(1, "Ny Pizza", "Nyt brød og kød, nemlig babek", 109);
        PizzaAdministration.PrintAllMenu();

        Console.WriteLine("Deleting Pizza");

        PizzaAdministration.DeletePizza(1);
        PizzaAdministration.PrintAllMenu();

        }
    } 
} 

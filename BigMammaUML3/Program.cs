using System;

namespace BigMammaUML3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer c1 = new Customer("Israa", "Birthevej 34", 123, "12121212");
            //ICustomer sc1 = new SpecialCustomer(12, "Ole", "gade 12", "21212121" );

            //ICustomerCatalog catalog = new CustomerCatalog();
            //catalog.AddCustomer(c1);
            //catalog.AddCustomer(sc1);
            //catalog.PrintCustomerList();

            IMenuCatalog mc = new MenuCatalog();

            try
            {

                //Pizza
                mc.Add(new Pizza(true, 1, "Margheritta", "med tomat og ost", 55, MenuType.Pizza, false, false));
                mc.Add(new Pizza(true, 2, "Italiana", "cheese, onion", 45, MenuType.Pizza, true, true));
                mc.Add(new Pizza(true, 2, "Italiana danish", "cheese, onion", 45, MenuType.Pizza, true, true));

                // Beverage
                mc.Add(new Beverage(false, 3, "Cola", "Mellem", 20, MenuType.SoftDrink, false, false));
                mc.Add(new Beverage(true, 4, "Drink", "stor", 60, MenuType.AlcoholicDrink, false, false));

                // Salat
                mc.Add(new Salat(true, false, 5, "Caesar salat", "Stor", 45, MenuType.Salat, true, true));
                mc.Add(new Salat(false, true, 6, "TunPasta", "pasta med tun", 55, MenuType.Salat, false, false));
            }
            catch (MenuItemNumberExist miex)
            {
                Console.WriteLine($"MenuItem eksisterer allerede {miex.Message} ");
            }



            Console.WriteLine(mc);

            Console.WriteLine("Tryk enter for afslut");
            Console.ReadLine();
        }
    }
}

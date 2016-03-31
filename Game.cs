using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Inventory inventoryList = new Inventory();
        Weather weather = new Weather();
        Store supplies = new Store();
      
       


        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            weather.WeatherGenerator();
            Console.WriteLine();
            Inventory menu = new Inventory();
            menu.DisplayPricesForSupplies();
            Console.WriteLine();
            supplies.PurchaseSupplies();
            Console.WriteLine();
            supplies.TotalSupplies();
            supplies.UpdateBudget();
            Store store = new Store();
            store.CreateCustomers();
            //supplies.DisplayLemonList();


            Console.Read();
           
        }
    }
}

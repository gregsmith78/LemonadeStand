using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
       // Store storeLemon = new Store();
       // Game player = new Game();

        public double lemons = .07;
        public double sugar = .03;
        public double ice = .03;
        public double cups = .04;

        public double totalCostLemons;
        public double totalCostCups;
        public double totalCostSugar;
        public double totalCostIce;
        public double totalCostSupplies;

        public void DisplayPricesForSupplies()
        {
            Console.WriteLine("Let's get the supplies you need to make your lemonade!");
            Console.WriteLine("Cups: " + cups);
            Console.WriteLine("Lemons: " + lemons);
            Console.WriteLine("Cups of Sugar: " + sugar);
            Console.WriteLine("Ice: " + ice);
            
        }

       
    }
}

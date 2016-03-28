using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Inventory inventoryList = new Inventory();
        Weather weather = new Weather();
        Store supplies = new Store();
      
       


        public void Start()
        {
            weather.WeatherGenerator();
            Console.WriteLine();
            supplies.PurchaseSupplies();
            Console.WriteLine();
            supplies.TotalSupplies();
            Console.Read();
           
        }
    }
}

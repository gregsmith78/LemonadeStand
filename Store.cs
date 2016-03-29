using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Store : Inventory

    {
        double budget = 15.00;
        double cupInput;
        double lemonInput;
        double iceInput;
        double sugarInput;
        double totalCostSupplies;

        public void PurchaseSupplies()
        {
            Console.WriteLine("How many cups would you like to buy?");
            cupInput = Convert.ToInt32(Console.ReadLine());
            CalculateCostOfCups();

            Console.WriteLine("How many lemons would you like to buy?");
            lemonInput = Convert.ToInt32(Console.ReadLine());
            CalculateCostOfLemons();

            Console.WriteLine("How many cups of sugar would you like to buy?");
            sugarInput = Convert.ToInt32(Console.ReadLine());
            CalculateCostOfSugar();

            Console.WriteLine("How much ice would you like to buy?");
            iceInput = Convert.ToInt32(Console.ReadLine());
            CalculateCostOfIce();
           // UpdateBudget();
           
        }
        public void CalculateCostOfLemons()
        {
            totalCostLemons = lemons * lemonInput;
           // return totalCostLemons;
           
        }

        public void CalculateCostOfCups()
        {
            totalCostCups = cups * cupInput;
           // return totalCostCups;
        }

        public void CalculateCostOfSugar()
        {
            totalCostSugar = sugar * sugarInput;
           // return totalCostSugar;
        }

        public void CalculateCostOfIce()
        {
            totalCostIce = ice * iceInput;
            //return totalCostIce;
        }

        public void TotalSupplies()
        {
            totalCostSupplies = totalCostSugar + totalCostCups + totalCostLemons + totalCostIce;
            Console.WriteLine("Your total cost for supplies is {0:c} ", totalCostSupplies);
            //Console.WriteLine(totalCostSupplies);
        }
        public double UpdateBudget()
        {
            budget -= totalCostSupplies;
            Console.WriteLine("You have a remaining balance of {0:c} ", budget);
            //budget = ("{0:C}", budget);
            return budget;
        }
    }
}

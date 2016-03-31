using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    public class Store

    {
        public double budget = 15.00;
        public double cupInput;
        public double lemonInput;
        public double iceInput;
        public double sugarInput;
        public double totalCostSupplies = 0;
        public double priceOfCup;
        Inventory inventory = new Inventory();
        List<Customer> customers = new List<Customer>();
        List<double> Lemons = new List<double>();
        List<double> Sugar = new List<double>();
        int numberOfCustomers = 30;
        Customer greg = new Customer(0, 0);
        Customer mike = new Customer(0, 0);
        Customer charles = new Customer(0, 0);
        Customer tyler = new Customer(0, 0);
        Customer justin = new Customer(0, 0);


        public void PurchaseSupplies()

        {
            totalCostSupplies = 0.0;
            try
            {
                Console.WriteLine("How many cups would you like to buy?");
                cupInput = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseSupplies();
            }
            CalculateCostOfCups();
            CalculateCostOfLemons();
            StoreLemons();

            try
            {
                Console.WriteLine("How many cups of sugar would you like to buy?");
                sugarInput = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseSupplies();
            }

            CalculateCostOfSugar();
            StoreSugar();
            try
            {
                Console.WriteLine("How many cubes of ice would you like to buy?");
                iceInput = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseSupplies();
            }
            CalculateCostOfIce();
            try
            {
                Console.WriteLine("What price would you like to set for a cup of lemonade based on the weather?");
                priceOfCup = Convert.ToDouble(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number...");
                PurchaseSupplies();
            }
        }

        public void CalculateCostOfLemons()
        {
            inventory.totalCostLemons = inventory.lemons * lemonInput;
           // return totalCostLemons;
           
        }

        public void CalculateCostOfCups()
        {
            inventory.totalCostCups = inventory.cups * cupInput;
           // return totalCostCups;
        }

        public void CalculateCostOfSugar()
        {
            inventory.totalCostSugar = inventory.sugar * sugarInput;
           // return totalCostSugar;
        }

        public void CalculateCostOfIce()
        {
            inventory.totalCostIce = inventory.ice * iceInput;
            //return totalCostIce;
        }

        public void TotalSupplies()
        {
            totalCostSupplies = inventory.totalCostSugar + inventory.totalCostCups + inventory.totalCostLemons + inventory.totalCostIce;
            Console.WriteLine("Your total cost for supplies is {0:c} ", totalCostSupplies);
            
        }
        public double getBudget()
        {
            return budget;
        }
        public double UpdateBudget()
        {


            if (totalCostSupplies > budget)
            {
                Console.WriteLine("You went over budget! Please go back and re-order your supplies.");
                //this.totalCostSupplies = 0.0;
                PurchaseSupplies();
                TotalSupplies();
                UpdateBudget();
               
            }
            
            else
            {
                budget -= totalCostSupplies;

                Console.WriteLine("You have a remaining balance of {0:c} ", budget);
                Console.ReadLine();
            }
            return budget;
        }

        public void StoreLemons()
        {
            Lemons.Add(lemonInput);
        }

        public void DisplayLemonList()
        {
            foreach (double item in Lemons)
            {
                Console.WriteLine(item);
            }
        }

        public void StoreSugar()
        {
            Sugar.Add(sugarInput);
        }
        public void DisplaySugarList()
        {
            foreach (double item in Sugar)
            {
                Console.WriteLine(item);
            }
        }

        public void CreateCustomers() 
        {
            for(int i = 0; i < numberOfCustomers; i++) 
            {
                Random random = new Random();
                Customer customer = new Customer(random.Next(1,4), random.Next(1, 50));
                customers.Add(customer);
                PayForDrink(customer);
               

            }
        }

        public List<Customer> AddToCustomerList(List<Customer> customers, Customer customer)
        {
            customers.Add(customer);
            
            return customers;
        }

        public void getCustomers()
        {
        foreach(Customer item in customers)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }
        }
        public void getStatusCustomerList()
        {
            customers.Add(greg);
            //getCustomers();
        }
        public void PayForDrink(Customer customer)
        {
            //Random rand = new Random();
            //customer.chanceOfBuying = rand.Next(1, 5);

            if (customer.mood > 1)

            {
                budget += priceOfCup;
            }
            if (customer.pay <= 20)
            {
                budget += priceOfCup;
            }

        }

















    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
       public double money;
       public string name;
       public bool isThirsty = true;
       public double price;

        public Customer(int customer)
        {
           // money = Money;
           // name = Name;
        }
        public List<Customer> CreateCustomer(int numberOfCustomers)
        { 
        List<Customer> customer = new List<Customer>();
            Random rand = new Random();
        
        for(int i = 0; i < numberOfCustomers; i++)
        {
                customer.Add(new Customer(rand.Next(0, 4)));
        }
            return customer;
        }
    }
}

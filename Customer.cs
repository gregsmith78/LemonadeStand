using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
       
        public string name;
        public bool isThirsty = true;
        public double price;
        public double chanceOfBuying;
        public int mood;
        public int moodEffect;
        public int weatherEffect;
        public int temperatureEffect;
        public int willPay;
        public int pay;
        //Store person = new Store();

       



        public Customer(int Mood, int Pay)
        {
            mood = Mood;
            pay = Pay;
        }

        public void MoodGenerator()
        {
            Random rand = new Random();
            mood = rand.Next(1, 4);

            if (mood == 1)
            {
                moodEffect = 5;
            }
            else if (mood == 2)
            {
                moodEffect = 10;
            }
            else if (mood == 3)
            {
                moodEffect = 15;
            }
            else
            {
                moodEffect = 20;
            }

        }
        public void ContentWithPrice()
        {
            Random rand = new Random();
            willPay = rand.Next(1, 50);

            if (willPay <= 10)
            {
                pay = 5;
            }
            else if (willPay > 10 && willPay <= 20)
            {
                pay = 10;
            }
            else if (willPay > 20 && willPay <= 30)
            {
                pay = 15;
            }
            else if (willPay > 30 && willPay <= 40)
            {
                pay = 20;
            }
            else
            {
                pay = 25;
            }
            

        }
       




    }
}



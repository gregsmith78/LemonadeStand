using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
     

        public void WeatherGenerator()
        {
            double temperature;
            string bright;
            Random temp = new Random();
            temperature = temp.Next(65, 100);

            if (temperature <= 74)
            {
                Console.WriteLine("The temperature is " +temperature+ " a bit cool and ");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("The temperature is " +temperature+ " hot outside and ");
            } 
            else
            {
                Console.WriteLine("The temperature is " +temperature+ " a scorcher and ");
            }
            Random brite = new Random();
            int feel = brite.Next(1, 5);

            if (feel == 1)
            {
                bright = "Sunny";
                Console.WriteLine(bright);
            }
            else if (feel == 2)
            {
                bright = "Cloudy";
                Console.WriteLine(bright);
            }
            else if (feel == 3)
            {
                bright = "Rainy";
                Console.WriteLine(bright);
            }
            else
            {
                bright = "Hazy";
                Console.WriteLine(bright);
            }


           // return temperature;


        }
      
    }
}

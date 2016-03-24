using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        double temperature;
        string bright;
        //int sunny;
       // int cloudy;
       // int rainy;

        public Weather()
        {
            Random temp = new Random();
            temperature = temp.Next(65, 100);
           // Console.WriteLine(temperature);
           // Console.ReadLine();

            if (temperature <= 74)
            {
                Console.WriteLine("The temperature is" +temperature+ " a bit cool and " + bright);
            }
            else if (temperature < 85)
            {
                Console.WriteLine("The temperature is " +temperature+ " hot outside and " + bright);
            } 
            else
            {
                Console.WriteLine("The temperature is " +temperature+ " a scorcher and " + bright);
            }
            Random brite = new Random();
            int feel = brite.Next(1, 4);

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





        }
    }
}

using System;

namespace Calculatory McCalculator-face
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Temperature");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the relative humidity");
            int humidity = int.Parse(Console.ReadLine());
            double dewpoint = (temp - ((100 - humidity)/25) * 9);
            Console.WriteLine("The dew point is" + dewpoint);

            Console.WriteLine("Enter the windspeed");
            int windspeed = int.Parse(Console.ReadLine());
            double windExp = Math.Pow(windspeed, 0.16);
            double windchill = 35.74 + (0.6215 * temp) - (35.75 * windExp) + (0.4275 * temp * windExp);
            Console.WriteLine("The wind chill is" + windchill);

            //bagels are just seagulls that fly over the bay
            
        }
    }
}
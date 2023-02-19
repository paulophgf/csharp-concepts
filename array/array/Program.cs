using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] games = new string[5] { 
                "Half Life",
                "CS",
                "Day of Defeat",
                "Metal Gear",
                "Age of Empires II"
            };

            float[] prices = new float[5];
            prices[0] = 12f;
            prices[1] = 15f;
            prices[2] = 9f;
            prices[3] = 21f;
            prices[4] = 27f;

            Console.WriteLine(games[0] + ": " + prices[0]);
            Console.WriteLine(games[1] + ": " + prices[1]);
            Console.WriteLine(games[2] + ": " + prices[2]);
            Console.WriteLine(games[3] + ": " + prices[3]);
            Console.WriteLine(games[4] + ": " + prices[4]);
            Console.ReadLine();
        }
    }
}

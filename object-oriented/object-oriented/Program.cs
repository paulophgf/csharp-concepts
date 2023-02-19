using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", 2019, 120000);
            Car gm = new Car("Blazer", 2009, 80000);

            Driver[] drivers = new Driver[5];
            drivers[0] = new Driver("Carlos", 28, 2300f, gm);
            drivers[1] = new Driver("John", 31, 3200f, bmw);
            drivers[2] = new Driver("Lucas", 25, 2400f, gm);
            drivers[3] = new Driver("Mario", 43, 3800f, bmw);
            drivers[4] = new Driver("Mike", 52, 5000f, bmw);

            foreach (var driver in drivers)
            {
                Console.WriteLine(driver.ToString());
            }
            Console.ReadLine();
        }
    }
}

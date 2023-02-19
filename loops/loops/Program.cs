using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            countTo10();
            countDownFrom10();
            listNames();
            Console.ReadLine();
        }

        static void countTo10()
        {
            Console.WriteLine("Count to 10");
            int count = 0;
            while (count <= 10)
            {
                Console.WriteLine("Count = " + count);
                count++;
            }
        }

        static void countDownFrom10()
        {
            Console.WriteLine("Count down");
            for (int i=10; i>=0; i--)
            {
                Console.WriteLine("Count = " + i);
            }
        }

        static void listNames()
        {
            string[] names = { "Paul", "John", "Mary", "Lucas", "Jane" };
            foreach(string name in names)
            {
                Console.WriteLine("Name = " + name);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string answer = Console.ReadLine();
            int age = int.Parse(answer); // You can use this way to convert: Convert.ToInt32(answer);
            if(age<12)
            {
                Console.WriteLine("You are a child");
            } 
            else if(age < 18)
            {
                Console.WriteLine("You are a teenager");
            }
            else if (age < 60)
            {
                Console.WriteLine("You are an adult");
            } else
            {
                Console.WriteLine("You are an old person");
            }
            Console.ReadLine();
        }
    }
}

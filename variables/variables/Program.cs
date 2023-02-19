using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables Types
            var example = "Test";
            Console.WriteLine("Var: " + example);

            // Variables Types
            int number = 1;
            float height = 1.75f;
            double salary = 2500.50;
            bool isActive = true;
            string texto = "Example";
            char letter = 'A';

            Console.WriteLine("Int: " + number);
            Console.WriteLine("Float: " + height);
            Console.WriteLine("Double: " + salary);
            Console.WriteLine("Boolean: " + isActive);
            Console.WriteLine("String: " + texto);
            Console.WriteLine("Character: " + letter);

            // Dynamic variable
            dynamic option = "Option 1";
            Console.WriteLine("Dynamic: " + option);

            option = 1;
            Console.WriteLine("Dynamic: " + option);


            // Constraints
            const float PI = 3.141592653589793f;
            Console.WriteLine("Constraint: " + PI);

            Console.ReadLine();
        }
    }
}

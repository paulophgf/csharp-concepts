using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            showMenuOptions();
            int option = readOption();
            float value1 = readValue(1);
            float value2 = readValue(2);

            float result = 0;
            switch(option)
            {
                case 1: result = sum(value1, value2); break;
                case 2: result = subtraction(value1, value2); break;
                case 3: result = division(value1, value2); break;
                case 4: result = multiplication(value1, value2); break;
            }

            showResult(result);
            Console.ReadLine();
        }

        static void showMenuOptions()
        {
            Console.WriteLine("Options");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
        }


        static int readOption()
        {
            return int.Parse(Console.ReadLine());
        }

        static float readValue(int number)
        {
            Console.WriteLine("Inform the value " + number + ": ");
            return float.Parse(Console.ReadLine());
        }

        static void showResult(float result)
        {
            Console.WriteLine("The result is: " + result);
        }


        static float sum(float value1, float value2)
        {
            return value1 + value2;
        }

        static float subtraction(float value1, float value2)
        {
            return value1 - value2;
        }

        static float division(float value1, float value2)
        {
            return value1 / value2;
        }

        static float multiplication(float value1, float value2)
        {
            return value1 * value2;
        }

    }
}

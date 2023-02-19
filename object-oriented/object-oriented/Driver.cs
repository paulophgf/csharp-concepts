using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    public class Driver : Person
    {
        float salary;
        Car car;

        public Driver()
        {
            Console.WriteLine("New driver instance created");
        }
        
        public Driver(string name, int age, float salary, Car car) : base(name, age)
        {
            this.salary = salary;
            this.car = car;
        }

        public int Salary { get; private set; }
        public int Car { get; private set; }

        public override string ToString()
        {
            return "Name: " + base.Name +
                "\nAge: " + base.Age + 
                "\nCar: " + car.GetName() +
                "\nSalary: " + salary;
        }

    }
}

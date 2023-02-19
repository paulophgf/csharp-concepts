using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    
    public class Car
    {
        // By default the attributes are private
        string _name;
        int _year;
        float _price;

        // Default constructor
        public Car()
        {
            Console.WriteLine("New car instance created");
        }

        // Constructor calling the default construtor before using this()
        public Car(string name, int year, float price) : this()
        {
            this._name = name;
            this._year = year;
            this._price = price;
        }

        // Encapsulation Java Way
        public string GetName()
        {
            return this._name;
        }
        public void SetName(string name)
        {
            this._name = name;
        }

        // Encapsulation C# pattern
        public int Year
        {
            get { return this._year; }
            set { this._year = value; } 
        }

        public float Price
        {
            get { return this._price; }
            set { this._price = value; }
        }

    }
}

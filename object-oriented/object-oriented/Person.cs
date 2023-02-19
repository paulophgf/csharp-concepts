using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace object_oriented
{
    public class Person
    {
        protected string _name;
        protected int _age;

        // Default constructor
        public Person() {
            Console.WriteLine("New person instance created");
        }

        // Constructor calling the default construtor before using this()
        public Person(string name, int age) : this()
        {
            _name = name;
            _age = age;
        }

        // Encapsulation C# pattern
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}

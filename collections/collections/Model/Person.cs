using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    public class Person
    {
        private int _id;
        private string _name;
        private string _email;
        private int _age;
        private float _salary;


        public Person(string name, string email, int age, float salary)
        {
            Name = name;
            Email = email;
            Age = age;
            Salary = salary;
        }


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public float Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }


        public override string ToString()
        {
            return "Person: {" +
                "\n   ID: " + Id +
                "\n   Name: " + Name +
                "\n   Email: " + Email +
                "\n   Age: " + Age +
                "\n   Salary: " + Salary +
                "\n}";
        }

    }
}

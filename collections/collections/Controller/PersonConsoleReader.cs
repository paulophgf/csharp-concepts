using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace collections.Controller
{
    public class PersonConsoleReader
    {

        public static Person Read()
        {
            Person person = null;
            string name = ReadName();
            if(!"exit".Equals(name))
            {
                string email = ReadEmail();
                if (!"exit".Equals(email))
                {
                    int age = ReadAge();
                    if(age != -1)
                    {
                        float salary = ReadSalary();
                        if (salary != -1f)
                        {
                            person = new Person(name, email, age, salary);
                        }
                    }
                }
            }
            return person;
        }

        public static int ReadId()
        {
            int id = -1;
            try
            {
                Console.WriteLine("ID: ");
                string value = Console.ReadLine();
                id = int.Parse(value);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid id");
            }
            return id;
        }

        private static string ReadName()
        {
            string name = "";
            bool validName = false;
            while (!validName)
            {
                Console.WriteLine("Inform the person's name (type 'exit' to cancel): ");
                name = Console.ReadLine();
                validName = !"".Equals(name.Trim());
                if(!validName)
                {
                    Console.WriteLine("Invalid name");
                }
            }
            return name;
        }

        private static string ReadEmail()
        {
            string email = "";
            bool validEmail = false;
            while (!validEmail)
            {
                Console.WriteLine("Inform the person's email (type 'exit' to cancel): ");
                email = Console.ReadLine();
                validEmail = !"".Equals(email.Trim()) && IsValidEmail(email);
                if (!validEmail)
                {
                    Console.WriteLine("Invalid email");
                }
            }
            return email;
        }

        private static bool IsValidEmail(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }

        private static int ReadAge()
        {
            int age = 0;
            bool validAge = false;
            while (!validAge)
            {
                Console.WriteLine("Inform the person's age (type 'exit' to cancel): ");
                string value = Console.ReadLine();
                if (!"exit".Equals(value))
                {
                    age = ValidateAge(value);
                    validAge = age != 0;
                } else
                {
                    validAge= true;
                    age = - 1;
                }
            }
            return age;
        }

        private static int ValidateAge(string value)
        {
            int age;
            try
            {
                age = int.Parse(value);
                if (age < 0 || age > 120)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid age");
                age = 0;
            }
            return age;
        }

        private static float ReadSalary()
        {
            float salary = 0f;
            bool validSalary = false;
            while (!validSalary)
            {
                Console.WriteLine("Inform the person's salary (type 'exit' to cancel): ");
                string value = Console.ReadLine();
                if (!"exit".Equals(value))
                {
                    salary = ValidateSalary(value);
                    validSalary = salary != 0f;
                }
                else
                {
                    validSalary = true;
                    salary = -1f;
                }
            }
            return salary;
        }

        private static float ValidateSalary(string value)
        {
            float salary;
            try
            {
                salary = float.Parse(value);
                if (salary < 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid salary");
                salary = 0;
            }
            return salary;
        }

    }

}
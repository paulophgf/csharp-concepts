using collections.Business;
using collections.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.Controller
{
    public class PersonConsoleController : IPersonController
    {

        private PersonBusiness personBusiness;


        public PersonConsoleController(PersonBusiness personBusiness) { 
            this.personBusiness = personBusiness;
        }


        public void Add()
        {
            try
            {
                Console.Clear();
                Person newPerson = PersonConsoleReader.Read();
                if (newPerson != null)
                {
                    personBusiness.Insert(newPerson);
                    Console.Clear();
                    Console.WriteLine("New person added");
                }
            } 
            catch(DuplicateNameException e) 
            {
                Console.WriteLine("The email " + e.Message + " is already in use.");
            }
            Console.ReadLine();
        }

        public void FindById()
        {
            Console.Clear();
            int id = PersonConsoleReader.ReadId();
            if(id != -1) {
                Person person = personBusiness.FindById(id);
                Console.Clear();
                Console.WriteLine(person);
                Console.ReadLine();
            }
        }

        public void ListAll()
        {
            Console.Clear();
            List<Person> list = personBusiness.List();
            if(list != null && list.Count > 0)
            {
                Console.WriteLine("ID   Name            Email            ");
                foreach (Person person in list)
                {
                    Console.WriteLine(person.Id + " " + person.Name + " " + person.Email);
                }
            } 
            else
            {
                Console.WriteLine("No people found");
            }
            Console.ReadLine();
        }

        public void Update()
        {
            try
            {
                Console.Clear();
                int id = PersonConsoleReader.ReadId();
                if (id != -1)
                {
                    Person person = PersonConsoleReader.Read();
                    if (person != null)
                    {
                        person.Id = id;
                        personBusiness.Update(person);
                        Console.Clear();
                        Console.WriteLine("Person updated");
                        Console.ReadLine();
                    }
                }
            }
            catch (DuplicateNameException e)
            {
                Console.WriteLine("The email " + e.Message + " is already in use.");
            }
        }

        public void Delete()
        {
            Console.Clear();
            int id = PersonConsoleReader.ReadId();
            if (id != -1)
            {
                Person person = personBusiness.FindById(id);
                if(person != null)
                {
                    personBusiness.Delete(person);
                    Console.Clear();
                    Console.WriteLine("Person deleted");
                }
            }
            Console.ReadLine();
        }

    }
}

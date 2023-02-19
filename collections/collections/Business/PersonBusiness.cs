using collections.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.Business
{
    public class PersonBusiness
    {
        private IPersonDAO personDAO;

        public PersonBusiness(IPersonDAO personDAO)
        {
            this.personDAO = personDAO;
        }


        public Person Insert(Person person)
        {
            bool existsEmail = personDAO.FindByEmail(person.Email) != null;
            if (existsEmail)
            {
                throw new DuplicateNameException(person.Email);
            }
            return personDAO.Insert(person);
        }

        public void Update(Person newPerson)
        {
            Person currentPerson = personDAO.FindById(newPerson.Id);
            if (currentPerson != null)
            {
                CheckDuplicatedEmail(newPerson, currentPerson);
                personDAO.Update(newPerson);
            }
        }

        public Person Delete(Person person)
        {
            return personDAO.Delete(person.Id);
        }

        public Person FindById(int id)
        {
            return personDAO.FindById(id);
        }

        public List<Person> List()
        {
            return personDAO.FindAll();
        }


        private void CheckDuplicatedEmail(Person newPerson, Person currentPerson)
        {
            Person personByEmail = personDAO.FindByEmail(newPerson.Email);
            if (personByEmail != null)
            {
                bool isTheSamePerson = personByEmail.Id.Equals(currentPerson.Id);
                if (!isTheSamePerson)
                {
                    throw new DuplicateNameException(newPerson.Email);
                }
            }
        }

    }
}

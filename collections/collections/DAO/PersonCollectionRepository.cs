using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.DAO
{
    public class PersonCollectionRepository : IPersonDAO
    {
        
        private static int SEQUENCE = 1;
        private static Dictionary<int, Person> personsDictionaryById = new Dictionary<int, Person>();
        private static Dictionary<string, Person> personsDictionaryByEmail = new Dictionary<string, Person>();


        Person IPersonDAO.Insert(Person person)
        {
            if(Equals(person.Id, null))
            {
                throw new NoNullAllowedException();
            }
            person.Id = SEQUENCE++;
            personsDictionaryById.Add(person.Id, person);
            personsDictionaryByEmail.Add(person.Email, person);
            return person;
        }

        void IPersonDAO.Update(Person newPerson)
        {
            Person currentPerson = personsDictionaryById[newPerson.Id];
            personsDictionaryById[newPerson.Id] = newPerson;
            personsDictionaryByEmail[currentPerson.Email] = newPerson;
        }

        Person IPersonDAO.Delete(int id)
        {
            Person person = personsDictionaryById[id];
            if(person != null)
            {
                personsDictionaryByEmail.Remove(person.Email);
                personsDictionaryById.Remove(person.Id);
            }
            return person;
        }

        List<Person> IPersonDAO.FindAll()
        {
            return personsDictionaryById.Values.ToList();
        }

        Person IPersonDAO.FindById(int id)
        {
            return personsDictionaryById[id];
        }

        Person IPersonDAO.FindByEmail(string email)
        {
            Person person = null;
            if(personsDictionaryByEmail.ContainsKey(email))
            {
                person = personsDictionaryByEmail[email];
            }            
            return person;
        }

    }
}

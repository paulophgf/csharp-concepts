using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.DAO
{
    public interface IPersonDAO
    {
        Person Insert(Person person);
        void Update(Person person);
        Person Delete(int id);
        List<Person> FindAll();
        Person FindById(int id);
        Person FindByEmail(String email); 
    }
}

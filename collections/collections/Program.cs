using collections.Business;
using collections.Controller;
using collections.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonDAO dao = new PersonCollectionRepository();
            PersonBusiness personBusiness = new PersonBusiness(dao);
            IPersonController controller = new PersonConsoleController(personBusiness);
            new MenuConsoleView(controller).Menu();
        }
    }
}

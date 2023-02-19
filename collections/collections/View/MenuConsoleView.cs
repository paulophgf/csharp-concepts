using collections.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.Controller
{
    public class MenuConsoleView
    {

        private IPersonController personController;


        public MenuConsoleView(IPersonController personController) { 
            this.personController = personController;
        }


        public void Menu()
        {
            int option;
            do
            {
                Console.Clear();
                option = SelectOption();
                ExecuteOption(option);
            } while (option != 0);
        }

        private void ExecuteOption(int option)
        {
            switch (option)
            {
                case 1: personController.Add(); break;
                case 2: personController.FindById(); break;
                case 3: personController.ListAll(); break;
                case 4: personController.Update(); break;
                case 5: personController.Delete(); break;
                case 0: break;
                default: Console.WriteLine("Invalid option"); break;
            }
        }

        private int SelectOption()
        {
            ShowMenuOptions();
            Console.WriteLine("Select an option:");
            return int.Parse(Console.ReadLine());
        }

        private void ShowMenuOptions()
        {
            Console.WriteLine("Options");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Find by ID");
            Console.WriteLine("3 - List All");
            Console.WriteLine("4 - Update");
            Console.WriteLine("5 - Delete");
            Console.WriteLine("0 - Exit");
        }

    }
}

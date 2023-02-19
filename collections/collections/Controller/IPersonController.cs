using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections.Controller
{
    public interface IPersonController
    {
        void Add();
        void FindById();
        void ListAll();
        void Update();
        void Delete();
    }
}

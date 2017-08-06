using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsV1.Workflows;

namespace ContactsV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Execute();
        }
    }
}

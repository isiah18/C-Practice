using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacePractice.Interface;

namespace InterfacePractice.Behaviors
{
    public class Shoot: IHit
    {
        public void Hit()
        {
            Console.WriteLine("Bang. You shot.");
        }

        public void Reload()
        {
            Console.WriteLine("Reloading....");
        }
    }
}

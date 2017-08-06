using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Shape
    {
        public virtual string SaySomething()
        {
            return "Something!";
        }
    }
}

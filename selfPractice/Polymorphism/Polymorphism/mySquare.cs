using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MySquare : Square
    {
        public override string SaySomething()
        {
            return "Something from MySquare";
        }
    }
}

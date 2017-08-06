using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class MiniVan : Car
    {
        public MiniVan(int maxSpeed) : base(maxSpeed)
        {
            
        }

        public MiniVan() : base(45)
        {
            
        }
    }
}

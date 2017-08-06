using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice.Interface
{
    public interface IItem
    {
        string Name { get; set; }

        void Shoot();
    }
}

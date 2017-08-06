using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacePractice.Behaviors;
using InterfacePractice.Interface;

namespace InterfacePractice
{
    public class Gun 
    {
        Shoot shootGun = new Shoot();
        public string Name { get; set; }

        public Gun()
        {
            Name = "Gun";
        }

        public void Shoot()
        {
            shootGun.Hit();
         
        }
    }
}

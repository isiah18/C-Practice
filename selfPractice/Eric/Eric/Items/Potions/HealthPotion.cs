using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Base;

namespace Eric.Items.Potions
{
    public class HealthPotion : Item
    {
        public HealthPotion()
        {
            Type = ItemType.Potion;
        }
    }

    public class Sword : Item
    {
        public Sword()
        {
            Type = ItemType.Weapon;
        }
    }
}

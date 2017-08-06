using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Interfaces;
using Eric.Items.Containers.Restrictions;

namespace Eric.Items.Containers
{
    public class PotionSatchel : Container
    {
        public PotionSatchel() : base(4, new List<IContainerRestriction>()
                                            {
                                                new EmptySlotRestriction(),
                                                new ItemTypeRestriction(ItemType.Potion),
                                                new WeightRestriction(10)
                                            })
        {
                
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Base;
using Eric.Interfaces;

namespace Eric.Items.Containers.Restrictions
{
    public class EmptySlotRestriction : IContainerRestriction
    {
        public AddItemStatus CheckItem(Container container, Item itemToAdd)
        {
            if(container.Capacity == container.CurrentIndex)
                return AddItemStatus.NoEmptySlots;

            return AddItemStatus.Ok;
        }
    }
}

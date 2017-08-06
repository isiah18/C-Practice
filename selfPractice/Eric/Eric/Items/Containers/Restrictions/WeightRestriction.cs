using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Base;
using Eric.Interfaces;

namespace Eric.Items.Containers.Restrictions
{
    public class WeightRestriction : IContainerRestriction
    {
        private int _maxWeight;

        public WeightRestriction(int maxWeight)
        {
            _maxWeight = maxWeight;
        }

        public AddItemStatus CheckItem(Container container, Item itemToAdd)
        {
            int currentWeight = container.Items.Sum(i => i.Weight);
            if (itemToAdd.Weight + currentWeight > _maxWeight)
                return AddItemStatus.ItemTooHeavy;

            return AddItemStatus.Ok;
        }
    }
}

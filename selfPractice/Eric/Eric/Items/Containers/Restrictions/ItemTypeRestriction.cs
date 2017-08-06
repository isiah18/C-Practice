using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Base;
using Eric.Interfaces;

namespace Eric.Items.Containers.Restrictions
{
    public class ItemTypeRestriction : IContainerRestriction
    {
        private ItemType _requiredType;

        public ItemTypeRestriction(ItemType requiredType)
        {
            _requiredType = requiredType;
        }

        public AddItemStatus CheckItem(Container container, Item itemToAdd)
        {
            if(itemToAdd.Type != _requiredType)
                return AddItemStatus.ItemWrongType;

            return AddItemStatus.Ok;
        }
    }
}

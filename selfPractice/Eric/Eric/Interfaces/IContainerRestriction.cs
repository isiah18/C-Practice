using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Base;
using Eric.Items.Containers;

namespace Eric.Interfaces
{
    public interface IContainerRestriction
    {
        AddItemStatus CheckItem(Container container, Item itemToAdd);
    }
}

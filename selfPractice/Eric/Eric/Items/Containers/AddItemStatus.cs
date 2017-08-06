using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eric.Items.Containers
{
    public enum AddItemStatus
    {
        Ok,
        NoEmptySlots,
        ItemWrongType,
        ItemTooHeavy
    }
}

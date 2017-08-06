using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Base;
using Eric.Interfaces;
using Eric.Items.Containers.Restrictions;

namespace Eric.Items.Containers
{
    public abstract class Container
    {
        private Item[] _items;
        private int _capacity;
        private List<IContainerRestriction> _restrictions;
        private int _currentIndex = 0;

        public int Capacity {  get {  return _capacity;} }
        public int CurrentIndex {  get { return _currentIndex; } }
        public Item[] Items { get { return _items; } }

        public Container(int capacity) : this(capacity, new List<IContainerRestriction>() { new EmptySlotRestriction() })
        {

        }

        public Container(int capacity, List<IContainerRestriction> restrictions)
        {
            _capacity = capacity;
            _items = new Item[_capacity];
            _restrictions = restrictions;

        }

        public AddItemStatus AddItem(Item itemToAdd)
        {
            foreach (var restriction in _restrictions)
            {
                var status = restriction.CheckItem(this, itemToAdd);
                if (status != AddItemStatus.Ok)
                {
                    return status;
                }
            }

            _items[_currentIndex] = itemToAdd;
            _currentIndex++;

            return AddItemStatus.Ok;
        }
    }
}

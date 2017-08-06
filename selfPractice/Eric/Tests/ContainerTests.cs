using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eric.Items.Containers;
using Eric.Items.Potions;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ContainerTests
    {
        [Test]
        public void CanAddItem()
        {
            Backpack b = new Backpack();
            Sword s = new Sword();

            var actual = b.AddItem(s);

            Assert.AreEqual(AddItemStatus.Ok, actual);
        }

        [Test]
        public void CannotAddItemWhenFull()
        {
            Backpack b = new Backpack();
            Sword s = new Sword();

            b.AddItem(s);
            b.AddItem(s);
            b.AddItem(s);
            var actual = b.AddItem(s);

            Assert.AreEqual(AddItemStatus.NoEmptySlots, actual);
        }

        [Test]
        public void RequiredItemType()
        {
            PotionSatchel b = new PotionSatchel();
            Sword s = new Sword();

            var actual = b.AddItem(s);

            Assert.AreEqual(AddItemStatus.ItemWrongType, actual);

            HealthPotion hp = new HealthPotion();
            actual = b.AddItem(hp);

            Assert.AreEqual(AddItemStatus.Ok, actual);
        }
    }
}

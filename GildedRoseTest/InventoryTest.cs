using System;
using Xunit;

namespace GildedRoseKataTest
{
    public class InventoryTest
    {
        [Fact]
        public void FailTest()
        {
            var inventory = new GildedRoseKata.Inventory();
            inventory.UpdateQuality();
            Assert.False(true);
        }
    }
}

using System;
using Xunit;
using FluentAssertions;

namespace GildedRoseKataTest
{
    public class InventoryTest
    {
        [Fact]
        public void FailTest()
        {
            var inventory = new GildedRoseKata.Inventory();
            inventory.UpdatePrice();
            Assert.False(true);
        }
    }
}

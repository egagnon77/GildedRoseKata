using Xunit;
using FluentAssertions;
using GildedRoseKata;

namespace GildedRoseKataTest
{
    public class InventoryTest
    {
        [Fact]
        public void GivenInventory_WhenUpdatePrice_ThenItemsPriceAndExpirationLowerBy1()
        {
            // Given
            var initialPrice = 10;
            var initialExpiration = 9;

            var inventory = new Inventory();
            inventory.Items = new [] {new Item {Price = initialPrice, Expiration = initialExpiration, Name = "TestItem"}};
            
            // When
            inventory.UpdatePrice();
            
            //Then
            var testItem = inventory.Items[0];
            testItem.Price.Should().Be(initialPrice-1);
            testItem.Expiration.Should().Be(initialExpiration-1);
        }
    }
}

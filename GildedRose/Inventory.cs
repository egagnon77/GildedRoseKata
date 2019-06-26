using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Inventory
    {
        public IList<Item> Items;

        public Inventory()
        {
            Initialize();
        }

        private void Initialize()
        {
            Items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", Expiration = 10, Price = 20},
                new Item {Name = "Aged Brie", Expiration = 2, Price = 0},
                new Item {Name = "Elixir of the Mongoose", Expiration = 5, Price = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", Expiration = 0, Price = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", Expiration = 15, Price = 20},
                new Item {Name = "Conjured Mana Cake", Expiration = 3, Price = 6}
            };
        }

        public void UpdatePrice()
        {
            foreach(var item in Items)
            {
                item.Price--;
                item.Expiration--;
            }
        }            
    }

    public class Item
    {
        public string Name { get; set; }
        public int Expiration { get; set; }
        public int Price { get; set; }         
    }
}


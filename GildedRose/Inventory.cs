using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Inventory
    {
        private IList<Item> Items;

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
            for (var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (Items[i].Price > 0)
                    {
                        if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                        {
                            Items[i].Price = Items[i].Price - 1;
                        }
                    }
                }
                else
                {
                    if (Items[i].Price < 50)
                    {
                        Items[i].Price = Items[i].Price + 1;

                        if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Expiration < 11)
                            {
                                if (Items[i].Price < 50)
                                {
                                    Items[i].Price = Items[i].Price + 1;
                                }
                            }

                            if (Items[i].Expiration < 6)
                            {
                                if (Items[i].Price < 50)
                                {
                                    Items[i].Price = Items[i].Price + 1;
                                }
                            }
                        }
                    }
                }

                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                {
                    Items[i].Expiration = Items[i].Expiration - 1;
                }

                if (Items[i].Expiration < 0)
                {
                    if (Items[i].Name != "Aged Brie")
                    {
                        if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (Items[i].Price > 0)
                            {
                                if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
                                {
                                    Items[i].Price = Items[i].Price - 1;
                                }
                            }
                        }
                        else
                        {
                            Items[i].Price = Items[i].Price - Items[i].Price;
                        }
                    }
                    else
                    {
                        if (Items[i].Price < 50)
                        {
                            Items[i].Price = Items[i].Price + 1;
                        }
                    }
                }
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


using System.Collections.Generic;
using GildedRose;

namespace GildedRoseKata
{
    public class GildedRose
    {

        IList<ItemWrapper> Items;

        public GildedRose(IList<Item> items)
        {
            Items = new List<ItemWrapper>();

            foreach (var item in items)
            {
                switch (item.Name)
                {
                    case "Aged Brie":
                        Items.Add(new AgedBrie(item));
                        break;
                    case "Backstage passes to a TAFKAL80ETC concert":
                        Items.Add(new BackstagePass(item));
                        break;
                    case "Sulfuras, Hand of Ragnaros":
                        Items.Add(new Sulfuras(item));
                        break;
                    case "Conjured Mana Cake":
                        Items.Add(new Conjured(item));
                        break;
                    default:
                        Items.Add(new RegularItem(item));
                        break;
                }
            }

        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                item.Update();
            }
        }
    }
}


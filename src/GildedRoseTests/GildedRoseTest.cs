using Xunit;
using System.Collections.Generic;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
        [Fact]
        public void ConjuredItems_DecreaseInQualityTwiceAsFast()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(4, Items[0].Quality);
        }

        [Fact]
        public void ConjuredItems_DecreaseInQualityTwiceAsFast_AfterSellByDate()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(2, Items[0].Quality);
        }
        // Additional tests for other items to ensure the refactor didn't break existing functionality
        [Fact]
        public void AgedBrie_IncreasesInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(1, Items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_IncreaseInQuality()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 11, Quality = 20 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(21, Items[0].Quality);
        }

        [Fact]
        public void BackstagePasses_QualityDropsToZeroAfterConcert()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(0, Items[0].Quality);
        }

        [Fact]
        public void Sulfuras_QualityDoesNotChange()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 } };
            GildedRoseKata.GildedRose app = new GildedRoseKata.GildedRose(Items);

            app.UpdateQuality();

            Assert.Equal(80, Items[0].Quality);
        }
   }

}

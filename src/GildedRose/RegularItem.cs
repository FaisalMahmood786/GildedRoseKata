using GildedRoseKata;

namespace GildedRose
{
    public class RegularItem : ItemWrapper
    {
        public RegularItem(Item item) : base(item) { }

        public override void Update()
        {
            Item.SellIn--;
            if (Item.Quality > 0)
            {
                Item.Quality--;
            }

            if (Item.SellIn < 0 && Item.Quality > 0)
            {
                Item.Quality--;
            }
        }
    }


}

using GildedRoseKata;

namespace GildedRose
{
    public class AgedBrie : ItemWrapper
    {
        public AgedBrie(Item item) : base(item) { }

        public override void Update()
        {
            Item.SellIn--;
            if (Item.Quality < 50)
            {
                Item.Quality++;
                if (Item.SellIn < 0 && Item.Quality < 50)
                {
                    Item.Quality++;
                }
            }
        }
    }

}

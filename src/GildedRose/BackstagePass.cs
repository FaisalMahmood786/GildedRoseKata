using GildedRoseKata;

namespace GildedRose
{
    public class BackstagePass : ItemWrapper
    {
        public BackstagePass(Item item) : base(item) { }

        public override void Update()
        {
            Item.SellIn--;
            if (Item.Quality < 50)
            {
                Item.Quality++;
                if (Item.SellIn < 10 && Item.Quality < 50)
                {
                    Item.Quality++;
                }
                if (Item.SellIn < 5 && Item.Quality < 50)
                {
                    Item.Quality++;
                }
            }

            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }

}

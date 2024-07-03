using GildedRoseKata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class Conjured : ItemWrapper
    {
        public Conjured(Item item) : base(item) { }

        public override void Update()
        {
            Item.SellIn--;
            if (Item.Quality > 0)
            {
                Item.Quality -= 2;
            }

            if (Item.SellIn < 0 && Item.Quality > 0)
            {
                Item.Quality -= 2;
            }
        }
    }
}

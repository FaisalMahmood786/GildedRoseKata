using GildedRoseKata;

namespace GildedRose
{
    public abstract class ItemWrapper
    {
        protected Item Item;

        protected ItemWrapper(Item item)
        {
            this.Item = item;
        }

        public abstract void Update();
    }

}

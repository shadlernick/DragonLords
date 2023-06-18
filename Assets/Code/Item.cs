using System;

namespace Creatures
{
    public enum ItemType
    {
        Consumable,
        PetSummon,
        Garbage
    }

    public interface IItem
    {
        public ItemType Type { get; set; }
    }

    public class Item : IItem
    {

    }
}
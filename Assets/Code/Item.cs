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
        public int Id { get; set; }
        public ItemType Type { get; set; }
    }

    public class Item : IItem
    {
        #region inherited
        public int Id { get; set; }
        public ItemType Type { get; set; }
        #endregion
    }
             
    public class UsableItem : IItem
    {
        #region inherited
        public int Id { get; set; }
        public ItemType Type { get; set; }
        #endregion

        public void Use() { }
    }
}
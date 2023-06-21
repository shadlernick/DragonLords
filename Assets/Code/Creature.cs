using System.Collections;
using System.Collections.Generic;

namespace Creatures
{
    public interface ICreature
    {
        public int HP { get; set; }
        public int MP { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }

        public int Name { get; set; }

        public int Level { get; set; }

        public bool IsDead { get; set; }
    }

    public class Player : ICreature
    {
        #region inherited
        public int HP { get; set; }
        public int MP { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }

        public int Name { get; set; }

        public int Level { get; set; }

        public bool IsDead { get; set; }
        #endregion

        private Inventory _inventory;

        public Player()
        {
            _inventory = new Inventory();
        }

        public void PickUp(IItem item, int count)
        {
            _inventory.AddItem(item, count);
        }
    }

    public class Dragon : ICreature
    {
        #region inherited
        public int HP { get; set; }
        public int MP { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }

        public int Name { get; set; }

        public int Level { get; set; }

        public bool IsDead { get; set; }
        #endregion
    }

    public class Mob : ICreature
    {
        #region inherited
        public int HP { get; set; }
        public int MP { get; set; }

        public int Attack { get; set; }
        public int Defense { get; set; }

        public int Name { get; set; }

        public int Level { get; set; }

        public bool IsDead { get; set; }
        #endregion
    }
}

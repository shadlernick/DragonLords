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

    }

    public class Dragon : ICreature
    {

    }

    public class Mob : ICreature
    {

    }
}

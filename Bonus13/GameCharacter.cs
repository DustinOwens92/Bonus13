using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class GameCharacter
    {
        public string Name { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
        }

        public virtual string Play()
        {
            return $"{Name}, {Strength}, {Intelligence}";
        }
    }
}

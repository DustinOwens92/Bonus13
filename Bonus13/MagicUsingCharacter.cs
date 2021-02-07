using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    public class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy  { get; }

        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base (name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }
        public override string Play()
        {
            return $"{Name}, {Strength}, {Intelligence}, {MagicalEnergy}";
        }

    }
}

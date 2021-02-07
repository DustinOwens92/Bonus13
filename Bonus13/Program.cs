using System;
using System.Collections.Generic;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Gimli", 72, 34, "Battle Axe"));
            gameCharacters.Add(new Warrior("Aragorn", 95, 72, "Warriors Sword"));
            gameCharacters.Add(new Wizard("Gandalf The Great", 15, 69, 99, 78));
            gameCharacters.Add(new Wizard("Sauron", 0,85, 70, 89));
            gameCharacters.Add(new Wizard("Galadriel", 5, 85, 85, 87));

            foreach (GameCharacter play in gameCharacters)
            {
                Console.WriteLine(play.Play());
            }
        }
    }
}

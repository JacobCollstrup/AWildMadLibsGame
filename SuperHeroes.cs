using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class SuperHeroes
    {
        List<string> superHeroes = new List<string>{ "Batman", "SuperMan", "Ironman", "Wonder Woman", "SuperGirl", "The Joker", "Thor", "The Credible Hulk", "Philosoraptor", "Harley Quinn", "Sponge Bob", "Dark Wing Duck" };
        public List<string> GetHeroes(int numberOfHeroes)
        {
            List<string> returnHeroes = new List<string>();
            var random = new Random();
            for (int i = 0; i <numberOfHeroes; i++)
            {
                int index = random.Next(superHeroes.Count);
                returnHeroes.Add(superHeroes[index]);
            }
            return returnHeroes;
        }
    }
}

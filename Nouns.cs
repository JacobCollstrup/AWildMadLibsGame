using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Nouns
    {
        List<string> nouns = new List<string> { "car", "fork", "computer", "house", "lamp", "fridge", "toilet", "bike", "road", "cloud", "tree", "lawnmower" };
        public List<string> GetNouns(int numberOfNouns)
        {
            List<string> returnNouns = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfNouns; i++)
            {
                int index = random.Next(nouns.Count);
                returnNouns.Add(nouns[index]);
            }
            return returnNouns;
        }
    }
}

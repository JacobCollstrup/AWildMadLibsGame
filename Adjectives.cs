using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Adjectives
    {
        List<string> adjectives = new List<string> { "racist", "blue", "silly", "confused", "hot", "cold", "attractive", "bright", "red", "dark", "woke", "green" };
        public List<string> GetAdjectives(int numberOfAdjectives)
        {
            List<string> returnAdjectives = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfAdjectives; i++)
            {
                int index = random.Next(adjectives.Count);
                returnAdjectives.Add(adjectives[index]);
            }
            return returnAdjectives;
        }
    }
}

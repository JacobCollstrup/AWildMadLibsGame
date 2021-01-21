using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Verbs
    {
        List<string> verbs = new List<string> { "fly", "bake", "run", "drive", "knit", "cook", "swim", "code", "play", "sleep", "yell", "talk" };
        public List<string> Getverbs(int numberOfVerbs)
        {
            List<string> returnVerbs = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfVerbs; i++)
            {
                int index = random.Next(verbs.Count);
                returnVerbs.Add(verbs[index]);
            }
            return returnVerbs;
        }
    }
}

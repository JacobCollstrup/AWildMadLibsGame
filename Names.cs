using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Names
    {
        List<string> names = new List<string> { "Bob", "John", "Mohammad", "Mustafa", "Joe", "Donald", "Sara", "Maria", "Connie", "Ann", "Joyce", "Kamala" };
        public List<string> GetNames(int numberOfNames)
        {
            List<string> returnNames = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfNames; i++)
            {
                int index = random.Next(names.Count);
                returnNames.Add(names[index]);
            }
            return returnNames;
        }
    }
}

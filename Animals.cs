using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Animals
    {
        List<string> animals = new List<string> { "dog", "parrot", "cat", "monkey", "rat", "bunny", "hamster", "lion", "orca", "squid", "antelope", "skunk" };
        public List<string> GetAnimals(int numberOfAnimals)
        {
            List<string> returnAnimals = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfAnimals; i++)
            {
                int index = random.Next(animals.Count);
                returnAnimals.Add(animals[index]);
            }
            return returnAnimals;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Fruit
    {
        List<string> fruits = new List<string> { "apple", "banana", "pear", "orange", "kiwi", "strawberry" };
        public List<string> GetFruits(int numberOfFruits)
        {
            List<string> returnFruits = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfFruits; i++)
            {
                int index = random.Next(fruits.Count);
                returnFruits.Add(fruits[index]);
            }
            return returnFruits;
        }
    }
}

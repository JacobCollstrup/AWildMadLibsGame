using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Food
    {
        List<string> foods = new List<string> { "omelette", "hot dog", "soup", "salad", "taco", "tortilla", "meatloaf", "steak", "burger" };
        public List<string> GetFoods(int numberOfFoods)
        {
            List<string> returnFoods = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfFoods; i++)
            {
                int index = random.Next(foods.Count);
                returnFoods.Add(foods[index]);
            }
            return returnFoods;
        }
    }
}

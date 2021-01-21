using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Desserts
    {
        List<string> desserts = new List<string> { "pancake", "waffle", "ice cream", "chocolate muffin", "tiramisu", "creme brulee", "apple pie" };
        public List<string> GetDesserts(int numberOfDesserts)
        {
            List<string> returnDesserts = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfDesserts; i++)
            {
                int index = random.Next(desserts.Count);
                returnDesserts.Add(desserts[index]);
            }
            return returnDesserts;
        }
    }
}

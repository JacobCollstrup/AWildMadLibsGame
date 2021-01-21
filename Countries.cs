using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Countries
    {
        List<string> countries = new List<string> { "Germany", "Denmark", "Chad", "Singapore", "China", "Brazil", "Canada", "Ethiopia", "Congo", "France", "Thailand", "Australia" };
        public List<string> GetCountries(int numberOfCountries)
        {
            List<string> returnCountries = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfCountries; i++)
            {
                int index = random.Next(countries.Count);
                returnCountries.Add(countries[index]);
            }
            return returnCountries;
        }
    }
}

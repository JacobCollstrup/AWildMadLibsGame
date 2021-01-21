using System;
using System.Collections.Generic;
using System.Text;

namespace AWildMadLibsGame
{
    public class Years
    {
        List<string> years = new List<string> { "1920", "2020", "2021", "1933", "1945", "1977", "1984", "1955", "1996", "1969", "2012", "1983" };
        public List<string> GetYears(int numberOfYears)
        {
            List<string> returnYears = new List<string>();
            var random = new Random();
            for (int i = 0; i < numberOfYears; i++)
            {
                int index = random.Next(years.Count);
                returnYears.Add(years[index]);
            }
            return returnYears;
        }
    }
}

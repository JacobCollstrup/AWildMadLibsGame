using System;
using System.Collections.Generic;

namespace AWildMadLibsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a mad-libs game in C#
            Author: Jacob Collstrup
            */


            // Let the user know that the program is starting:
            Console.WriteLine("Starting the madlibs game...");


            // Give the Mad Lib a title:
            string title = "A wild madlibs game appears!";
            
            
            Console.WriteLine(title);
                        
            Names listOfNames = new Names();
            List<string> name = listOfNames.GetNames(1);

            Adjectives listOfAdjectives = new Adjectives();
            List<string> adjectives = listOfAdjectives.GetAdjectives(3);

            Verbs listOfVerbs = new Verbs();
            List<string> verb = listOfVerbs.Getverbs(1);

            Nouns listOfNouns = new Nouns();
            List<string> nouns = listOfNouns.GetNouns(2);

            Animals listOfAnimals = new Animals();
            List<string> animal = listOfAnimals.GetAnimals(1);

            Food listOfFoods = new Food();
            List<string> food = listOfFoods.GetFoods(1);

            Fruit listOfFruits = new Fruit();
            List<string> fruit = listOfFruits.GetFruits(1);

            SuperHeroes listOfHeroes = new SuperHeroes();
            List<string> hero = listOfHeroes.GetHeroes(1);

            Countries listOfCountries = new Countries();
            List<string> country = listOfCountries.GetCountries(1);

            Desserts listOfDesserts = new Desserts();
            List<string> dessert = listOfDesserts.GetDesserts(1);

            Years listOfYears = new Years();
            List<string> year = listOfYears.GetYears(1); 

            
            // The template for the story:

            string story = $"This morning {name[0]} woke up feeling {adjectives[0]}. 'It is going to be a {adjectives[1]} day!'\nOutside, a bunch of {animal[0]}s were protesting to keep {food[0]} in stores.\nThey began to {verb[0]} to the rhythm of the {nouns[0]}, which made all the {fruit[0]}s very {adjectives[2]}.\nConcerned, {name[0]} texted {hero[0]}, who flew {name[0]} to {country[0]} and dropped {name[0]} in a puddle of frozen {dessert[0]}. \n{name[0]} woke up in the year {year[0]}, in a world where {nouns[1]}s ruled the world.";

            // Print the story:
            Console.WriteLine(story);
            Console.ReadKey();
            
        }
    }
}

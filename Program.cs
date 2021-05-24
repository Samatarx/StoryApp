using System;

namespace StoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
     This program is a poem
     Author: Samatar
     */


            // Let the user know that the program is starting:
            string intro = "Welcom to the MadLibs Challenge";
            Console.WriteLine(intro);

            // Give the Mad Lib a title:
            string title = "Fresh Prince of Bel Air";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Yoo whats your name");
            string name = Console.ReadLine();
            Console.WriteLine("I need you to write 1 adjective:");
            string adj1 = Console.ReadLine();
            Console.WriteLine("and a second...");
            string adj2 = Console.ReadLine();
            Console.WriteLine("and just one more to make it 3");
            string adj3 = Console.ReadLine();
            Console.WriteLine("aight, you any good with verbs?");
            string verb = Console.ReadLine();
            Console.WriteLine("now hit me with one noun");
            string noun1 = Console.ReadLine();
            Console.WriteLine("and second to make it sweet");
            string noun2 = Console.ReadLine();
            Console.WriteLine("now we need to go faster, one animal name:");
            string animal = Console.ReadLine();
            Console.WriteLine("one food name:");
            string food = Console.ReadLine();
            Console.WriteLine("one fruit name:");
            string fruit = Console.ReadLine();
            Console.WriteLine("one superhero name:");
            string superhero = Console.ReadLine();
            Console.WriteLine("one country name:");
            string country = Console.ReadLine();
            Console.WriteLine("one dessert name:");
            string dessert = Console.ReadLine();
            Console.WriteLine("last one!! pick a year:");
            string year = Console.ReadLine();
            // The template for the story:

            string story = $"This morning {name} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}

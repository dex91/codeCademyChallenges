using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program graps input from user to complete the story, to finally print the story out :)
      Author: Benjamin Aranda <visualdevelopers.de>
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Welcome to MAD Libs - A short story or not?");
      Console.WriteLine("We will ask you for a main charakter name, some nouns, verbs and adjectives to print out our MAD-Lip :). You'll wonder how the story will go trought.");
      Console.WriteLine();
      Console.WriteLine("Wait! We will ask more as we said above, but you will see it soon. Btw we can see sharp, got it? C#! ,_.");
      Console.WriteLine();
      Console.Write("Press any key to start the MAD Lip or enter q to quit: ");
      if(Console.ReadKey().Key == ConsoleKey.Q){
        Console.WriteLine();
        Environment.Exit(0);
      }
      Console.Clear();


      // Give the Mad Lib a title:
      string title = "##### Just an MAD Lib #####";

      Console.WriteLine(title);
      // Define user input and variables:

      // Declare Variables first!
      string characterName = "";
      string adjectiveOne = "";
      string adjectiveTwo = "";
      string adjectiveThree = "";
      string verb = "";
      string nounOne = "";
      string nounTwo = "";
      string animal = "";
      string food = "";
      string fruit = "";
      string superHero = "";
      string country = "";
      string dessert = "";
      string year = "";

      // Now we can grap each input from the user :)
      // Well we can do it so, or we declare and initialize the vars within readline at the point of user input....

      Console.Write("Enter a character name: ");
      characterName = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);


      Console.WriteLine("-- Please provide now three adjectives --");
      Console.Write("(1/3) Enter an adjective: ");
      adjectiveOne = Console.ReadLine();     

      Console.Write("(2/3) Enter an adjective: ");
      adjectiveTwo = Console.ReadLine();

      Console.Write("(3/3) Enter an adjective: ");
      adjectiveThree = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);      

      Console.Write("Please provide now exactly ONE verb: ");
      verb = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.WriteLine("-- Please provide now two nouns --");
      Console.Write("(1/2) Enter an noun: ");
      nounOne = Console.ReadLine();     

      Console.Write("(2/2) Enter an noun: ");
      nounTwo = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.Write("Please provide now an animal: ");
      animal = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.Write("Please provide now a food: ");
      food = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.Write("Please provide now an fruit: ");
      fruit = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.Write("Please provide now an superhero: ");
      superHero = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.Write("Please provide now an country: ");
      country = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title); 

      Console.Write("Please provide now an dessert: ");
      dessert = Console.ReadLine();
      Console.Clear();
      Console.WriteLine(title);

      Console.Write("Please provide now an year: ");
      year = Console.ReadLine();
      Console.Clear();                                

      // The template for the story:

      string story = $"This morning {characterName} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {characterName} texted {superHero}, who flew {characterName} to {country} and dropped {characterName} in a puddle of frozen {dessert}. {characterName} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


      // Print the story:
      Console.WriteLine(title);
      Console.WriteLine(story);
      Console.WriteLine();
      Console.WriteLine("Press any key to exit. Thanks for using MAD Lips!");    
      Console.ReadLine();


    }
  }
}

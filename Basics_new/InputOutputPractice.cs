using System;

namespace Treehouse.PracticeSession
{
    class Program
    {
        static void Main()
        {
            // TODO Declare and assign a "thing" string variable.
            // Example: "movie", "book", "color", etc.
            var thing = "fruit";

            // TODO Prompt the user with the text "What is your name?" 
            // and assign their value to a "name" string variable.
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            // TODO Prompt the user with the text 
            // "What is your favorite <thing>?" 
            // and assign their value to a "favoriteThing" string variable.
            Console.Write("What is your favorite " + thing + "? ");
            var favoriteThing = Console.ReadLine();

            // TODO Write the user's name and favorite thing to the console.
            // Example: "My name is James and my favorite movie is Toy Story."
            Console.WriteLine("My name is " + name + " and my favorite fruit is " + favoriteThing);
        }
    }
}

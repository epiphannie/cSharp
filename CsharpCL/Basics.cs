using System;
namespace codeLouisvilleCsharp
{
    public class Basics
    {
        static void Main()
        {
            var runningTotal = 0.0;

            while (true)
            {
                //Prompt the user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                var entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                try
                {
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable answer.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing.");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Good job.");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("Great job.");
                    }
                    else
                    {
                        Console.WriteLine("Best job");
                    }
                        //Add minutes exercised to the total
                        //Display total minutes exercised to the screen
                    runningTotal += minutes;
                    Console.WriteLine("You've exercised " + runningTotal + " minutes.");

                }

                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid input.");
                    continue;
                }

            }
        }
    }
}
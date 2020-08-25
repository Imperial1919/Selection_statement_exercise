using System;

namespace Selection_statement_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("Too Low!, try again!");
            }

            else if(userInput > favNumber)
            {
                Console.WriteLine("That is WAY too high a guess.");
            }

            else
            {
                Console.WriteLine("... errrrrrr... not totally sur ehow you came up with that but.. ya know what? \n Nevermind.");
            }

        }
    }
}

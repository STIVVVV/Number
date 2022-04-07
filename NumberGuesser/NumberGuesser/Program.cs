using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    internal class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Set app Vars
            string appName = "NumberGuesser Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;  

            Console.WriteLine("{0}: Version {1} BY {2}", appName, appVersion, appAuthor + "\n");

            Console.ResetColor();

            //Ask user's name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            //Init correct number
            int correctNumber = 7;

            //Init guess var
            int guess = 0;


            //ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct
            while (guess != correctNumber)
            {
                string input = Console.ReadLine();

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                

                if (guess != correctNumber)
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    //Write out app info
                    Console.WriteLine("Wrong number, please try again");

                    //Change text color
                    Console.ResetColor();
                }

                   

            }
        }
    }
}

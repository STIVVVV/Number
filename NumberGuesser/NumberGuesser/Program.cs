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
            GetAppInfo();

            GreetUser();

            while (true)
            {
                //create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;


                //ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.DarkRed, "Please use an actual number");

                        //keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //set error message
                        PrintColorMessage(ConsoleColor.DarkCyan, "You entered the wrong number try again.");
                    }
                }

                //output success message
                PrintColorMessage( ConsoleColor.DarkGreen, "correct number");

                //ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }

                else
                {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        { 
            //Set app Vars
            string appName = "NumberGuesser Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Traversy";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;  

            Console.WriteLine("{0}: Version {1} BY {2}", appName, appVersion, appAuthor + "\n");

            Console.ResetColor();
        }


        //ask users name and greet
        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game... \n", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //tell user its the wrong number
            Console.WriteLine(message);

            //Change text color
            Console.ResetColor();
        }
    }
}

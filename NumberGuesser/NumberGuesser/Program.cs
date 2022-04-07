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

            Console.WriteLine("{0}: Version {1} BY {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            appInfo();
            Console.WriteLine("What's your name? ");

            string input = Console.ReadLine();

            Console.WriteLine("Welcome {0} !", input);

            while (true)
            {


                //int correctNumber = 7;

                Random randomNumber = new Random();

                int correctNumber = randomNumber.Next(1, 10);

                Console.WriteLine("Guess a number between 1 to 10");

                int guess = 0;


                while (guess != correctNumber)
                {
                    string inputNumber = Console.ReadLine();


                    if (!int.TryParse(inputNumber, out guess))
                    {
                        printMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }
                    guess = Int32.Parse(inputNumber);

                    if (guess == correctNumber)
                    {
                        printMessage(ConsoleColor.Yellow, "You guessed the correct number");
                        Console.WriteLine("Play Again? [Y N]");

                        
                        string answer = Console.ReadLine().ToUpper();
                        
                        if(answer == "Y")
                        {
                            continue;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        printMessage(ConsoleColor.Red, "Wrong Number, try again");
                    }
                }
            }
        }
        static void printMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void appInfo()
        {
            string name = "Vijay";
            string appVersion = "1.0.0";
            string appName = "Number Guesser";

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0} : Version: {1} By: {2} ", appName, appVersion, name);
            Console.ResetColor();

        }
    }
}

using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess > 10)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please enter a number between 1-10");

                        continue;
                    }

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }


                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");
  
                Console.WriteLine("Play Again? [Y or N]");

                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";

            string appDescription = appName + ": Version " + appVersion;

            PrintColorMessage(ConsoleColor.Green, appDescription);
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name? ");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game....", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(text);

            Console.ResetColor();
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Declarations
        string userInput;
        int firstNumber = 0;
        int secondNumber = 0;
        int answer = 0;
        int operators = 0;
        int mathProblems = 0;

        // Begin the game
        Console.WriteLine("Let's play a math game!");
        Console.WriteLine("I will provide you with a math equation and you provide the solution.\n");
        Console.WriteLine("When you are ready, press any key to continue.");
        Console.ReadLine();

        do
        {
            Console.Clear();
            Random number = new Random();
            firstNumber = number.Next(1,100);
            secondNumber = number.Next(1,100);
            operators = number.Next(1,5);

            switch (operators)
            {
                case 1:
                    answer = firstNumber + secondNumber;
                    break;
                case 2:
                    answer = firstNumber - secondNumber;
                    break;
                case 3:
                    answer = firstNumber * secondNumber;
                    break;
                case 4:
                    answer = firstNumber / secondNumber;
                    break;
                default:
                    break;
            }
        } while (mathProblems != 5);
    }
}
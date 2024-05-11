using System;

class Program
{
    public static Random rnd { get; set; }
    static void Main(string[] args)
    {
        // Declarations
        int userInput;
        int firstNumber = 0;
        int secondNumber = 0;
        int answer = 0;
        int operators = 0;
        int mathProblems = 0;
        //int jerry = 0;

        // Begin the game
        Console.WriteLine("Let's play a math game!");
        Console.WriteLine("I will provide you with a math equation and you provide the solution.\n");
        Console.WriteLine("When you are ready, press the enter key to continue.");
        Console.ReadLine();

        do
        {
            Console.Clear();
            Random number = new Random();
            firstNumber = number.Next(1, 101);
            secondNumber = number.Next(1, 101);
            operators = number.Next(1, 5);

            switch (operators)
            {
                case 1:
                    answer = firstNumber + secondNumber;
                    Console.WriteLine(firstNumber + " + " + secondNumber + " = ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if(userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's incorrect. Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    break;
                case 2:
                    answer = firstNumber - secondNumber;
                    Console.WriteLine(firstNumber + " - " + secondNumber + " = ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's incorrect. Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    break;
                case 3:
                    answer = firstNumber * secondNumber;
                    Console.WriteLine(firstNumber + " * " + secondNumber + " = ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's incorrect. Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    break;
                case 4:
                    var randomNumber = 0;
                    var randomDivisor = new Random();
                    do
                    {
                        randomNumber = randomDivisor.Next(1, 101);
                        answer = randomNumber / secondNumber;
                    } while (randomNumber % secondNumber != 0);

                    Console.WriteLine(randomNumber + " / " + secondNumber + " = ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that's incorrect. Press the enter key for the next question.");
                        Console.ReadLine();
                        mathProblems++;
                    }
                    break;
                default:
                    Console.WriteLine("Sorry, I didn't receive valid input."); // This does not work like this
                    break;
            }
        } while (mathProblems != 5);
    }

    /*public static int getRandomMultiple(int divisor, int min, int max)
    {
        if (rnd == null)
        {
            rnd = new Random();
        }
        if(min > max)
        {
            int temp = max;
            max = min;
            min = temp;
        }

        int nextRandom = rnd.Next(min, max + 1);
        
        while (nextRandom % divisor != 0) 
        {
            nextRandom = rnd.Next(min, max + 1);
        }
        return nextRandom;
    }*/
}
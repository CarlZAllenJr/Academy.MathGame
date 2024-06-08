using System;
using System.Threading.Tasks;
using System.Timers;

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
        int correctAnswers = 0;
        int questionQuantity = 0;


        /*// Make timer for challenge
        System.Timers.Timer gameLength = new System.Timers.Timer(1000);
        gameLength.Elapsed += Timer_Elapsed;
        gameLength.Start();*/

        // Begin the game
        Console.WriteLine("Let's play a math game!");
        Console.WriteLine("I will provide you with a math equation and you provide the solution.\n");
        Console.WriteLine("When you are ready, press the enter key to continue.");
        Console.ReadLine();

        // Choosing Amount of Questions
        Console.Clear();
        Console.WriteLine("Please input the number of questions you would like to answer for the game: \n");
        questionQuantity = Convert.ToInt32(Console.ReadLine());

        do
        {
            // Choosing Math Function
            Console.Clear();
            Console.WriteLine("Choose a math function for the next question: \n");
            Console.WriteLine("1 = Addition \n");
            Console.WriteLine("2 = Subtraction \n");
            Console.WriteLine("3 = Multiplication \n");
            Console.WriteLine("4 = Division \n");
            operators = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Random number = new Random();
            firstNumber = number.Next(1, 101);
            secondNumber = number.Next(1, 101);
            /*operators = number.Next(1, 5);*/

            switch (operators)
            {
                case 1:
                    answer = firstNumber + secondNumber;
                    Console.WriteLine("\n" + firstNumber + " + " + secondNumber + " = \n");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        correctAnswers++;
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
                    Console.WriteLine("\n" + firstNumber + " - " + secondNumber + " = \n");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        correctAnswers++;
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
                    Console.WriteLine("\n" + firstNumber + " * " + secondNumber + " = \n");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        correctAnswers++;
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

                    Console.WriteLine("\n" + randomNumber + " / " + secondNumber + " = \n");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == answer)
                    {
                        Console.WriteLine("Great Job! Press the enter key for the next question.");
                        Console.ReadLine();
                        correctAnswers++;
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
        } while (mathProblems != questionQuantity);

        Console.WriteLine("You got " + correctAnswers + " out of " + mathProblems + " correct!");
    }

    /*private static void Timer_Elapsed(object? sender, ElapsedEventArgs e)
    {
        Console.WriteLine(DateTime.Now);
    }*/

    class Games
    {

        // List to track questions
        List<int> review = new List<int>();


    }
}
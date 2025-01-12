using System;
using System.Runtime.CompilerServices;

namespace MathGame
{
    internal class Program
    {
        static void DisplayGameMenu(string? playerName,DateTime startDate)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Hi {playerName}, It's {startDate}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1.Addition Game");
            Console.WriteLine("2.Subtraction Game");
            Console.WriteLine("3.Multiplication Game");
            Console.WriteLine("4.Divison Game");
            Console.WriteLine("5.Player stats");
            Console.WriteLine("6.Change player");
            Console.WriteLine("Your choice: ");
        }

        static int PlayAddGame()
        {   Random random = new Random();
            int rounds = 0;
            int score= 0;
            int numberOfRounds = 5;
            int numberA = random.Next(0, 50);
            int numberB=random.Next(0, 50);
            
            string playerResponse;
            while(rounds < numberOfRounds)
            {
                Console.WriteLine($" round {rounds+1} out of {numberOfRounds}");
                Console.WriteLine($"{numberA} + {numberB} = ");          
                playerResponse = Console.ReadLine();
                if(Int32.TryParse( playerResponse, out int parsedResponse))
                {
                    if(numberA+numberB == parsedResponse)
                    {
                        Console.WriteLine("Correct!");
                        numberA=random.Next(0, 50);
                        numberB=random.Next(0,50);
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        numberA = random.Next(0, 50);
                        numberB = random.Next(0, 50);
                    }
                    rounds++;

                }
                else
                {

                    Console.WriteLine("Wrong input, try again (only integers)");
                }

                
            }
            Console.WriteLine($"Final score: {score}/{numberOfRounds}");
            Console.WriteLine("Click any key to return to main menu");
            Console.ReadLine();
            return score;
        }
        static int PlaySubGame()
        {
            Random random = new Random();
            int rounds = 0;
            int score = 0;
            int numberOfRounds = 5;
            int numberA = random.Next(0, 50);
            int numberB = random.Next(0, 50);

            string playerResponse;
            while (rounds < numberOfRounds)
            {
                Console.WriteLine($" round {rounds + 1} out of {numberOfRounds}");
                Console.WriteLine($"{numberA} - {numberB} = ");
                playerResponse = Console.ReadLine();
                if (Int32.TryParse(playerResponse, out int parsedResponse))
                {
                    if (numberA - numberB == parsedResponse)
                    {
                        Console.WriteLine("Correct!");
                        numberA = random.Next(0, 50);
                        numberB = random.Next(0, 50);
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        numberA = random.Next(0, 50);
                        numberB = random.Next(0, 50);
                    }
                    rounds++;

                }
                else
                {

                    Console.WriteLine("Wrong input, try again (only integers)");
                }


            }
            Console.WriteLine($"Final score: {score}/{numberOfRounds}");
            Console.WriteLine("Click any key to return to main menu");
            Console.ReadLine();
            return score;
        }
        static int PlayMulGame()
        {
            Random random = new Random();
            int rounds = 0;
            int score = 0;
            int numberOfRounds = 5;
            int numberA = random.Next(0, 50);
            int numberB = random.Next(0, 50);

            string playerResponse;
            while (rounds < numberOfRounds)
            {
                Console.WriteLine($" round {rounds + 1} out of {numberOfRounds}");
                Console.WriteLine($"{numberA} * {numberB} = ");
                playerResponse = Console.ReadLine();
                if (Int32.TryParse(playerResponse, out int parsedResponse))
                {
                    if (numberA * numberB == parsedResponse)
                    {
                        Console.WriteLine("Correct!");
                        numberA = random.Next(0, 50);
                        numberB = random.Next(0, 50);
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        numberA = random.Next(0, 50);
                        numberB = random.Next(0, 50);
                    }
                    rounds++;

                }
                else
                {

                    Console.WriteLine("Wrong input, try again (only integers)");
                }


            }
            Console.WriteLine($"Final score: {score}/{numberOfRounds}");
            Console.WriteLine("Click any key to return to main menu");
            Console.ReadLine();
            return score;
        }
        static int[] GetDivisibleNumbers()
        {
            int[] numbers = new int[2];
            Random random = new Random();
            int numberA;
            int numberB;
            do
            {
                numberA = random.Next(0, 50);
                numberB = random.Next(1, 50);
            }
            while (numberA % numberB != 0);
            numbers[0] = numberA;
            numbers[1] = numberB;
            return numbers;
        }
        static int PlayDivGame()
        {
            Random random = new Random();
            int rounds = 0;
            int score = 0;
            int numberOfRounds = 5;
            int[] numbers = GetDivisibleNumbers();
            int numberA=numbers[0];
            int numberB=numbers[1];
   


            string playerResponse;
            while (rounds < numberOfRounds)
            {
                Console.WriteLine($" round {rounds + 1} out of {numberOfRounds}");
                Console.WriteLine($"{numberA} / {numberB} = ");
                playerResponse = Console.ReadLine();
                if (Int32.TryParse(playerResponse, out int parsedResponse))
                {
                    if (numberA / numberB == parsedResponse)
                    {
                        Console.WriteLine("Correct!");
                         numbers = GetDivisibleNumbers();
                         numberA = numbers[0];
                         numberB = numbers[1];
                        score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        numbers = GetDivisibleNumbers();
                        numberA = numbers[0];
                        numberB = numbers[1];
                    }
                    rounds++;

                }
                else
                {

                    Console.WriteLine("Wrong input, try again (only integers)");
                }


            }
            Console.WriteLine($"Final score: {score}/{numberOfRounds}");
            Console.WriteLine("Click any key to return to main menu");
            Console.ReadLine();
            return score;
        }
        static void Main(string[] args)
        {
            string? playerName;
            List<string> playerLogs=new();
            Console.WriteLine("Welcome to the Math Game! Please tell me your username: ");
            playerName = Console.ReadLine();
            if (playerName == "")
            {
                throw new ArgumentException(nameof(playerName),"Player name cannot be null.");
            }
            string? choice="";
            do
            {

                var startDate=DateTime.Now;
                int playerScore = 0;
                DisplayGameMenu(playerName,startDate);
                 choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        playerScore=PlayAddGame();
                        string playerLog = $"{playerName} -- Addition Game -- score: {playerScore}/5 date: {DateTime.Now}";
                        playerLogs.Add(playerLog);
                        break;
                    case "2":
                        playerScore=PlaySubGame();
                        playerLog = $"{playerName} -- Subtraction Game -- score: {playerScore}/5 date: {DateTime.Now}";
                        playerLogs.Add(playerLog);
                        break;
                    case "3":
                        playerScore = PlayMulGame();
                        playerLog = $"{playerName} -- Multiplication Game -- score: {playerScore}/5 date: {DateTime.Now}";
                        playerLogs.Add(playerLog);
                        break;
                    case "4":
                        playerScore = PlayDivGame();
                        playerLog = $"{playerName} -- Division Game -- score: {playerScore}/5 date: {DateTime.Now}";
                        playerLogs.Add(playerLog);
                        break;
                    case "5":
                        foreach (var log in playerLogs)
                        {
                            Console.WriteLine(log);
                        }
                        Console.WriteLine("Press any key to continue");
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Please enter new name for your profile: ");
                        playerName = Console.ReadLine();
                        Console.WriteLine("Succes!");
                        break;
                    default:
                        Console.WriteLine("Incorrect choice,please try again");
                        break;

                }
            } while (choice.ToLower() != "exit");
            

            
        }
    }
}

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? playerName;

            string? choice="";
            do
            {
                Console.WriteLine("Welcome to the Math Game! Please tell me your username: ");
                playerName = Console.ReadLine();
                var startDate=DateTime.Now;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Hi {playerName}, It's {startDate}");
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Addition Game");
                Console.WriteLine("2.Subtraction Game");
                Console.WriteLine("3.Multiplication Game");
                Console.WriteLine("4.Divison Game");
                Console.WriteLine("5.Player stats");
                Console.WriteLine("Your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;


                }
            } while (choice.ToLower() != "exit");
            

            
        }
    }
}

//Main Class
class Program
{
    //Call functions
    static void Main(string[] args)
    {
        // Runs the initial application information
        GetAppInfo();
        // Ask userName and Greet.
        Greet();
        // Start the game
        //Game();
        // Ask if they want to play again
        Continue();
    }

    //Functions
    static void GetAppInfo()
    {
        string creatorName = "Zachariah";
        string applicationVersion = "1.0.0";
        string applicationName = @"
  _   _                 _                _____                               
 | \ | |               | |              / ____|                              
 |  \| |_   _ _ __ ___ | |__   ___ _ __| |  __ _   _  ___  ___ ___  ___ _ __ 
 | . ` | | | | '_ ` _ \| '_ \ / _ \ '__| | |_ | | | |/ _ \/ __/ __|/ _ \ '__|
 | |\  | |_| | | | | | | |_) |  __/ |  | |__| | |_| |  __/\__ \__ \  __/ |   
 |_| \_|\__,_|_| |_| |_|_.__/ \___|_|   \_____|\__,_|\___||___/___/\___|_|   
                                                                             
                                                                             
";

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("{0}: Version {1}. Created by {2}", applicationName, applicationVersion, creatorName);
        Console.ResetColor();
    }

    static void Greet()
    {
        string userName = "";
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write("What is your name?: ");
        userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + "! Let's play a game.");
    }

    static void ColorMessage(ConsoleColor color, string message)
    {
        // Changes Text color to parameter color
        Console.ForegroundColor = color;
        // Log the message
        Console.WriteLine(message);
        // Reset Color -- Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }

    static void Continue()
    {
        Console.Write("Want to play? [Y or N]: ");

        string answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
            Game();
        }
        else if (answer != "N")
        {
            ColorMessage(ConsoleColor.Red, "Please choose either Y or N: ");
            Continue();
        }
        else
        {
            ColorMessage(ConsoleColor.DarkBlue, "Hope you had fun!");
            return;
        }
    }
    static void Game()
    {
        // Variable declaration
        Random random = new Random();
        int correctNumber = random.Next(1, 11);
        int guess = 0;
        // Prompt
        Console.Write("Guess a number between 1 and 10: ");
        // Responding logic
        while (guess != correctNumber)
        {
            // Gets User input
            string guessInput = Console.ReadLine();

            // Makes sure it's a number
            if (!int.TryParse(guessInput, out guess))
            {
                ColorMessage(ConsoleColor.Red, "Please use a number");
                // Do not end function
                continue;
            }

            guess = Int32.Parse(guessInput);

            if (guess != correctNumber)
            {
                ColorMessage(ConsoleColor.Red, "Incorrect, Please try again.");
            }
        }

        // Correct number
        ColorMessage(ConsoleColor.Green, "Correct!");
        Continue();
    }

}
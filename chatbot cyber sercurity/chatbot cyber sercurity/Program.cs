using CyberBot.App;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Cybersecurity Awareness Bot";

        ConsoleEffects.ShowAsciiArt("Assets/ascii_logo.txt");
        AudioPlayer.PlayGreeting("Assets/greeting.wav");

        ConsoleEffects.PrintWithDivider("Welcome to the Cybersecurity Awareness Bot!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        ConsoleEffects.PrintWithDivider($"Hello, {name}! Let's chat about cybersecurity.");

        while (true)
        {
            ConsoleEffects.PrintUserInputPrompt();
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                ConsoleEffects.PrintBotResponse("Please enter something.");
                continue;
            }

            if (input.ToLower() == "exit")
            {
                ConsoleEffects.PrintBotResponse("Goodbye! Stay safe online, " + name + "!");
                break;
            }

            string response = TopicHandler.GetResponse(input);
            ConsoleEffects.PrintBotResponse(response);
        }
    }
}



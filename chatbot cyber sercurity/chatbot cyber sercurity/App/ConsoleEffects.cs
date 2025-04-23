using System;
using System.IO;
using System.Threading;

namespace CyberBot.App
{
    public static class ConsoleEffects
    {
        public static void ShowAsciiArt(string path)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            if (File.Exists(path))
                Console.WriteLine(File.ReadAllText(path));
            else
                Console.WriteLine("[CyberBot ASCII art missing]");

            Console.ResetColor();
        }

        public static void PrintWithDivider(string message)
        {
            string border = new string('═', message.Length + 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n╔{border}╗");
            Console.WriteLine($"║    {message}    ║");
            Console.WriteLine($"╚{border}╝");
            Console.ResetColor();
        }

        public static void PrintUserInputPrompt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n💬 You: ");
            Console.ResetColor();
        }

        public static void PrintBotResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("🤖 CyberBot: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            TypeEffect(message);
            Console.ResetColor();
        }

        private static void TypeEffect(string text, int delay = 10)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}



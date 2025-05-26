using System;
using System.Collections.Generic;
using System.Media;
using System.Threading;

class Program
{
    static string userName = "";
    static string userInterest = "";

    static void Main()
    {
        ShowAsciiArt();
        GreetUser();
        RunChatbot();
    }

   
    
    static void ShowAsciiArt()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"

____ _
/ ___|_ __ ___ _ _| | ___ ___ ___ ___ __ _ _ __
| | | '__/ _ \| | | | |/ _ \/ __/ __|/ __/ _` | '_ \
| |___| | | (_) | |_| | | __/\__ \__ \ (_| (_| | | | |
\____|_| \___/ \__,_|_|\___||___/___/\___\__,_|_| |_|
_____ _
| ____|_ __ ___ _ __ | ___ ___ _ __ __ _ _ __ ___
| _| | '_ ` _ \| '_ \|/ _ \ / _ \| '__/ _` | '_ \ / _ \
| |___| | | | | | |_) | (_) | (_) | | | (_| | | | | __/
|_____|_| |_| |_| .__/ \___/ \___/|_| \__,_|_| |_|\___|
|_|
");

Console.ForegroundColor = ConsoleColor.Cyan;
Console.ResetColor();


       
    }

    static void GreetUser()
    {
        Console.Write("Hello! What’s your name? ");
        userName = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(userName))
        {
            Console.Write("Please enter a valid name: ");
            userName = Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nWelcome, {userName}! I'm your Cybersecurity Awareness Bot ");
        Console.WriteLine("Ask me anything about online safety, like password safety, phishing, or browsing tips.");
        Console.ResetColor();
    }

    static void RunChatbot()
    {
        while (true)
        {
            Console.Write("\n You: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("I didn't catch that. Can you try again?");
                continue;
            }

            if (input.Contains("bye") || input.Contains("exit"))
            {
                Console.WriteLine($"Goodbye, {userName}! Stay safe online!");
                break;
            }

            // Sentiment
            if (input.Contains("worried") || input.Contains("anxious"))
            {
                Console.WriteLine(" It's okay to feel that way. I'm here to help you stay safe.");
            }
            else if (input.Contains("confused"))
            {
                Console.WriteLine(" Cybersecurity can be tricky. I’ll explain as best I can.");
            }

            // Interests (memory)
            if (input.Contains("interested in"))
            {
                int index = input.IndexOf("interested in") + "interested in".Length;
                userInterest = input.Substring(index).Trim();
                Console.WriteLine($" Noted! You’re interested in {userInterest}. I’ll remember that.");
            }

            // Topic recognition
            if (input.Contains("password"))
            {
                PasswordSafety.Respond();
            }
            else if (input.Contains("phishing"))
            {
                Phishing.Respond();
            }
            else if (input.Contains("browsing") || input.Contains("safe browsing"))
            {
                SafeBrowsing.Respond();
            }
            else if (GeneralResponses.Respond(input)) { }
            else
            {
                Console.WriteLine(" I’m not sure I understand. Can you rephrase?");
            }
        }
    }
}

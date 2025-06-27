using System;
using System.Media;

namespace CyberSecurityChatBot
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Title = "CyberSecurity Awareness ChatBot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            DisplayAsciiArt();
            GreetUser();

            // Play the greeting audio when the chatbot starts
            PlayGreetingAudio();

            using (SoundPlayer player = new SoundPlayer("Assets/cybersecurityVoice.wav"))
            {
                player.PlaySync();  // Play the audio synchronously (wait until it finishes before proceeding)
            }

            Console.ResetColor();
            Console.WriteLine("\nYou can now ask me questions. Type 'exit' to end the chat.");

            string input;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                input = Console.ReadLine()?.ToLower();

                Console.ForegroundColor = ConsoleColor.Green;

                RespondToUser(input);

            } while (input != "exit");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nThank you for chatting! Stay safe online. 👋");
            Console.ResetColor();
        }

        static void DisplayAsciiArt()
        {
            Console.WriteLine(@"
   ____            _              ____       _           _   
  / ___| ___ _ __ | |_ ___ _ __  / ___|  ___| | ___  ___| |_ 
 | |    / _ \ '_ \| __/ _ \ '__| \___ \ / _ \ |/ _ \/ __| __| 
 | |___|  __/ | | | ||  __/ |     ___) |  __/ |  __/ (__| |_ 
  \____|\___|_| |_|\__\___|_|    |____/ \___|_|\___|\___|\__| 
                                                             
            Cybersecurity Awareness ChatBot
");
        }

        static void GreetUser()
        {
            Console.Write("\nHi there! 👋 What's your name? ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter a valid name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine($"\nWelcome, {name}! I'm your cybersecurity assistant.");
            Console.WriteLine("Ask me anything about online safety, phishing, or passwords.");
        }

        static void PlayGreetingAudio()
        {
            
            
        }

        static void RespondToUser(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("I didn't quite understand that. Could you try rephrasing?");
            }
            else if (input.Contains("how are you"))
            {
                Console.WriteLine("I'm just code, but I'm here to help you stay safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("My purpose is to teach you how to protect yourself online.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Phishing is when attackers trick you into giving away personal info through fake emails or links.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Always use strong passwords — a mix of letters, numbers, and symbols!");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Avoid clicking suspicious links. Always check for HTTPS in the URL.");
            }
            else if (input != "exit")
            {
                Console.WriteLine("Hmm... I'm still learning. Try asking about phishing, passwords, or safe browsing.");
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hangdude { 

    class Program {
    
        static void Main(string[] args) {
            // Show Title
            Console.WriteLine("Hangdude");
            Console.WriteLine("========");

            // Init Variables
            string secret =  "Secret Phrase";
            string guessed = "";
            int totalGuesses = 0;

            // Main Loop
            while (totalGuesses < 5) {

                // Show Revealed Word
                var previouslyRevealed = string.Join("", Reveal(secret, guessed));
                Console.WriteLine("{0}\r\n{1}", 
                    drawHangdude(totalGuesses),
                    previouslyRevealed);

                // Prompt For Next Letter
                Console.Write("Chose a letter: ");
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                guessed += pressedKey.KeyChar;
                Console.WriteLine("");

                // Test Chosen Letter
                var currentlyRevealed = string.Join("", Reveal(secret, guessed));
                if (currentlyRevealed != previouslyRevealed) {
                    Console.WriteLine();
                    // Right Answer
                    if (currentlyRevealed.ToLower() == secret.ToLower()) {
                        // Winner
                        Console.WriteLine("Winner!");
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        break;
                    } else {
                        Console.Beep();
                    }
                } else {
                    // Wrong Answer
                    Console.WriteLine("Wrong answer.");
                    Console.WriteLine("");
                    Console.Beep(300, 500);
                    totalGuesses++;
                    if (totalGuesses == 5) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(drawHangdude(5));
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Beep(300, 250);
                        Console.Beep(250, 750);
                        Console.Beep(200, 1000);
                    }
                }
            }
            // Show Game Over
            Console.WriteLine("Game Over. Press a key to exit...");
            Console.Read();
        }

        public static IEnumerable<char> Reveal(string secret, string guessed) {
            foreach (var letter in secret.ToCharArray()) {
                if (guessed.ToLower().Contains(letter.ToString().ToLower())) {
                    yield return letter;
                } else {
                    yield return 
                        (Regex.IsMatch(letter.ToString(), "[a-zA-Z]"))
                            ? '*'
                            : letter;
                }
            }
        }

        private static string drawHangdude(int tries) {
            string hangdudeTemplate = "o-|-<";
            if (tries > 0) {
                return hangdudeTemplate.Substring(0, tries);
            } else {
                return "";
            }
        }
    }
}
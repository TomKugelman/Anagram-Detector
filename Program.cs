using System;
using System.Linq;

namespace Anagram_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Enter two strings and find out whether they are anagrams! \n" +
                    "NOTE: No numbers or special characters.\n" +
                    "Start by pressing any key, or you can quit this program by pressing the ESCAPE key.");

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                    break;

                Console.Write("First Word: ");
                string wordOne = Console.ReadLine().ToLower().Trim();
                Console.Write("Second Word: ");
                string wordTwo = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (ValidateInput(wordOne) && ValidateInput(wordTwo))
                {
                    bool anagrams = AreAnagrams(wordOne, wordTwo);

                    if (anagrams)
                    {
                        Console.WriteLine($"Success! {wordOne} and {wordTwo} are anagrams!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{wordOne} and {wordTwo} are not anagrams.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine();
                }
            }
        }

        private static bool AreAnagrams(string wordOne, string wordTwo)
        {
            // If both words are not the same length, they cannot be anagrams
            if (wordOne.Length == wordTwo.Length)
            {
                foreach (char element1 in wordOne)
                {
                    foreach (char element2 in wordTwo)
                    {
                        if (element1 == element2)
                        {
                            // Removing pairs we find to avoid duplicates
                            wordOne = wordOne.Remove(wordOne.IndexOf(element1.ToString()), 1);
                            wordTwo = wordTwo.Remove(wordTwo.IndexOf(element2.ToString()), 1);
                        }
                    }
                }

                // If both words have had all their characters removed 
                // (i.e a matched pair for each character), they are anagrams
                if (wordOne.Length == 0 && wordTwo.Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        private static bool ValidateInput(string word)
        {
            string specialCharacters = "!@#$%^&*(),./<>?;:[]{}|`~\'\'\"\"\\+=_- ";
            string capitals = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // Check for integers, return false if any are found
            foreach (char element in word)
            {
                if (int.TryParse(element.ToString(), out _))
                    return false;
            }

            // Check for special characters
            foreach (char element in specialCharacters)
            {
                if (word.Contains(element))
                    return false;
            }

            // Check for capital letters
            foreach (char element in capitals)
            {
                if (word.Contains(element))
                    return false;
            }

            // If we get here there are no extraneous characters
            return true;
        }
    }
}

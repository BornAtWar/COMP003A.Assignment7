using System.Runtime.InteropServices;

namespace COMP003A.Assignment7
{
    //Author: Demetrius Richards
    //Purpose: Assignment 7
    //Class: COMP-003A-L01
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**************************************************");
            Console.WriteLine("Array - CharacterCounter Section");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Please enter a letter:");
            char letter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Please Enter a Word:");
            string word = Console.ReadLine();

            int count = 0;
            foreach (char c in word)
            {
                if (c == letter)
                {
                    count++;
                }

            }

            Console.WriteLine($"There are {count} letter '{letter}' in the word {word}");

            Console.WriteLine("*****************************************************");
            Console.WriteLine("Array -IsPalindrome Section");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Please enter a word to check if it is a palindrome");
            string palindrome = Console.ReadLine();

            bool isPalindrome = true;
            for (int i = 0; i < palindrome.Length / 2; i++)
            {
                if (palindrome[i] == palindrome[palindrome.Length - i - 1])
                {
                    isPalindrome = false;

                    
                }

            }

            Console.WriteLine($"Is the word {palindrome} a palindrome: {isPalindrome}");

            Console.WriteLine("********************************************************");
            Console.WriteLine("List - Add Section");
            Console.WriteLine("********************************************************");
            List<string> names = new List<string>();
            string input;
            do
            {
                Console.WriteLine("Please enter a name:");
                input = 
                    Console.ReadLine();
                if (input == "e")
                {
                    names.Add(input);
                }
                
            } while (input == "e");

            Console.WriteLine("******************************************************");
            Console.WriteLine("List - Traversal Section");
            Console.WriteLine("******************************************************");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("******************************************************");
            Console.WriteLine("List - Reverse Traversal Section");
            Console.WriteLine("******************************************************");
            foreach (var name in names)
            {
                char[] charArray = name.ToCharArray();

                Array.Reverse(charArray);
                string reversedName = new string(charArray);
                Console.WriteLine(reversedName);
            }
                        
        }  
    }
}

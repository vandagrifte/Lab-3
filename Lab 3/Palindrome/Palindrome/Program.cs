using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to see if it's a palindrome.");
            string userInput = Console.ReadLine();
            userInput = FormatThatThing(userInput);

            if (Palindromer(userInput)==true) { Console.WriteLine("It is a palindrome"); }
            else Console.WriteLine("It is not a palindrome");
        }

        static bool Palindromer(string str)
        {
            int strLength = str.Length;
            if (strLength == 1)
            { return true; }
            else if (strLength == 2)
            {
                if (str[0] == str[strLength - 1]) { return true; }
                else { return false; }
            }
            else if (str[0] == str[strLength - 1])
            { return Palindromer(str.Substring(1, strLength - 2)); }
            else return false;
        }
        static string FormatThatThing(string str)
        {
            str = str.ToLower();
            str = str.Trim();
            string returnString = "";
            foreach (char c in str)
            {
                if (char.IsLetter(c)) { returnString += c; }
            }
            return returnString;
        }
    }
}

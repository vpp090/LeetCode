using System;

namespace MyApp
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            string current = s.ToLower();

            int startIndex = 0;
            
            int endIndex = current.Length - 1;
            while (startIndex <= endIndex)
            {
                while (startIndex <= endIndex && !Char.IsAsciiLetterOrDigit(current[startIndex]))
                    startIndex++;
                while (startIndex <= endIndex && !Char.IsAsciiLetterOrDigit(current[endIndex]))
                    endIndex--;

                if (startIndex <= endIndex && current[startIndex] != current[endIndex])
                    return false;

                startIndex++;
                endIndex--;
            }

            return true;
        }
        static void Main(string[] args)
        {
            var result = IsPalindrome("A man, a plan, a canal: Panama");

            Console.WriteLine(result);
        }
    }
}
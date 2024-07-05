using System;

namespace Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "csharp is programming language";
            string reversed = StringManipulation.ReverseWords(input);
            Console.WriteLine(reversed);  // Output: "language programming is csharp"
        }
    }

    public class StringManipulation
    {
        public static string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            string[] words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(' ', words);
        }
    }
}

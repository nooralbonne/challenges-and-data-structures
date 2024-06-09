using System;

namespace whiteboard_challenges
{
    public class ArrayUtilities
    {
        public static int MaximumValue(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 15, 8, 6, 12 };
            int[] array2 = { 1, 3, 5, 7, 9 };
            int[] array3 = { 7, 9, 13, 25, 5 };

            Console.WriteLine($"Maximum value in array1: {ArrayUtilities.MaximumValue(array1)}"); // Output: 15
            Console.WriteLine($"Maximum value in array2: {ArrayUtilities.MaximumValue(array2)}"); // Output: 9
            Console.WriteLine($"Maximum value in array3: {ArrayUtilities.MaximumValue(array3)}"); // Output: 25
        }
    }
}

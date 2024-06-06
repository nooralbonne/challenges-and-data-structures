using System;

namespace whiteboard_challenges
{
    internal class Program
    {
        static int[] ArrayReversal(int[] inputArray)
        {
            int startIndex = 0;
            int endIndex = inputArray.Length - 1;

            while (startIndex < endIndex)
            {
                inputArray[startIndex] = inputArray[endIndex];
                inputArray[endIndex] = inputArray[startIndex];
                startIndex++;
                endIndex--;
            }

            return inputArray;
        }

        static void Main()
        {
            // Example inputs
            int[] input1 = { 1, 2, 3, 4, 5 };
            int[] input2 = { 42, 8, 15, 23, 42 };
            int[] input3 = { 7, 9, 13, 25 };

            // Testing the function
            int[] output1 = ArrayReversal(input1);
            int[] output2 = ArrayReversal(input2);
            int[] output3 = ArrayReversal(input3);

            // Printing the results
            Console.WriteLine($"Input: [1, 2, 3, 4, 5] Output: [{string.Join(", ", output1)}]");
            Console.WriteLine($"Input: [42, 8, 15, 23, 42] Output: [{string.Join(", ", output2)}]");
            Console.WriteLine($"Input: [7, 9, 13, 25] Output: [{string.Join(", ", output3)}]");
        }
    }
}
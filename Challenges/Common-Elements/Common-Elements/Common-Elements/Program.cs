using System;

namespace Common_Elements
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 1, 2, 5, 6 };
            int[] result = FindCommonElements(array1, array2);

            Console.WriteLine("Common Elements:");
            foreach (int element in result)
            {
                Console.WriteLine(element);
            }
        }

        public static int[] FindCommonElements(int[] array1, int[] array2)
        {
            int maxLength = Math.Min(array1.Length, array2.Length);
            int[] tempArray = new int[maxLength];
            int count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j] && !ElementExists(tempArray, array1[i], count))
                    {
                        tempArray[count] = array1[i];
                        count++;
                    }
                }
            }

            int[] result = new int[count];
            Array.Copy(tempArray, result, count);
            return result;
        }

        private static bool ElementExists(int[] array, int element, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

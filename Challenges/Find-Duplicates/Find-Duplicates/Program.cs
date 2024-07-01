namespace Find_Duplicates
{
    public class Program
    {
        public static int[] FindDuplicates(int[] array)
        {
            List<int> duplicates = new List<int>();
            bool[] checkedElements = new bool[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (checkedElements[i])
                {
                    continue;
                }

                bool isDuplicate = false;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        checkedElements[j] = true;
                    }
                }

                if (isDuplicate)
                {
                    duplicates.Add(array[i]);
                }
            }
            return duplicates.ToArray();
        }

        // Test the FindDuplicates function
        public static void Main()
        {
            int[] array1 = { 1, 2, 3, 1, 2, 3 };
            int[] result1 = FindDuplicates(array1);
            Console.WriteLine("Input: " + string.Join(", ", array1));
            Console.WriteLine("Output: " + string.Join(", ", result1) + "\n");

            int[] array2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] result2 = FindDuplicates(array2);
            Console.WriteLine("Input: " + string.Join(", ", array2));
            Console.WriteLine("Output: " + string.Join(", ", result2) + "\n");

            int[] array3 = { 5, 10, 16, 20, 10, 16 };
            int[] result3 = FindDuplicates(array3);
            Console.WriteLine("Input: " + string.Join(", ", array3));
            Console.WriteLine("Output: " + string.Join(", ", result3));
        }
    }
}


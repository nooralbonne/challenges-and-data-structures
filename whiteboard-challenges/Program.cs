using System;
public class GFG
{
    public static int mostFrequent(int[] arr, int n)
    {
        int maxcount = 0;
        int element_having_max_freq = 0;
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                }
            }

            if (count > maxcount)
            {
                maxcount = count;
                element_having_max_freq = arr[i];
            }
        }

        return element_having_max_freq;
    }

    public static void Main(String[] args)
    {
        int[] arr = { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };
        int n = arr.Length;
        Console.Write(mostFrequent(arr, n));
    }
}
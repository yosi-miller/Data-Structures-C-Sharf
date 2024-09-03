using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    public class Arrays
    {
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        // sum all items in array
        public static int SumArray(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return sum;
        }

        // fine minimum
        public static int FindMin(int[] arr)
        {
            int min = 0;
            foreach (int num in arr)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] merged = new int[arr1.Length + arr2.Length];
            int i1 = 0;
            int i2 = 0;

            while (i1 < arr1.Length && i2 < arr2.Length)
            {
                if (arr1[i1] < arr2[i2])
                {
                    merged[i1 + i2] = arr1[i1];
                    i1++;
                }
                else
                {
                    merged[i1 + i2] = arr2[i2];
                    i2++;
                }
            }

            // הוספת הערכים הנותרים ממערך arr1 אם נשארו
            while (i1 < arr1.Length)
            {
                merged[i1 + i2] = arr1[i1];
                i1++;
            }

            // הוספת הערכים הנותרים ממערך arr2 אם נשארו
            while (i2 < arr2.Length)
            {
                merged[i1 + i2] = arr2[i2];
                i2++;
            }

            return merged;
        }

        public static int[] NumbersFrequency(int[] arr)
        {
            int max = arr.Max();
            Console.Write(max);
            int[] result = new int[max];

            for (int i = 0; i < arr.Length; i++)
                result[arr[i] - 1]++;

            return result;
        }

        // order to zigzag
        public static int[] ZigzagSort(int[] arr)
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    arr[i] = arr[i - 1];
                    arr[i - 1] = arr[i];
                }
            }
            return arr;
        }
    }
}

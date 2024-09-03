using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    public class Sorts
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }

        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            int temp = 0;
            for (int i = 1; i < (n - 1); i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            int n = array.Length;
            int temp;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; (j > 0) && (array[j - 1] > array[j]); j--)
                {
                    temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;
                }
            }
            return array;
        }

        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; (i < array.Length); i++)
            {
                int minIndex = i;
                for (int j = (i + 1); j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                    if (i != minIndex)
                    {
                        int temp = array[i];
                        array[i] = array[minIndex];
                        array[minIndex] = temp;
                    }
                }
            }
            return array;
        }

        //public static int[] MergeSort(int[] array)
        //{ }
    }
}

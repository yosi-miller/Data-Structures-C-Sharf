using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises
{
    public class Generic
    {
        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}

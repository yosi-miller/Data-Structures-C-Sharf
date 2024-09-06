using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Exercises.Homework
{
    public class Complication
    {
        // Q1
        public static int CalculateOddSum(int[] array)
        {
            int sum = 0;
            // במקום לגשת למיקום של הערך במערך בזיכרון שומרים פעפם אחת בכל לולאה
            // ובודקים מול המשתנה הזה
            int check;
            for (int i = 0; i < array.Length; i++)
            {
                check = array[i];
                if (check % 2 != 0)
                    sum += check;
            }
            return sum;
        }

        // Q2
        public static (int max, int max1) FindMaximumTwo(int[] array)
        {
            int max = array[0];
            int max1 = array[1];
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i - 1] > max && array[i] > max1)
                    max = array[i - 1];
                max1 = array[i];
            }

            return (max, max1);
        }

        // Q3
        public bool ContainsNumber(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                    return true;
            }
            return false;
        }

        //public static int FindMaxElement(int[] array)
        //{ }
    }
}

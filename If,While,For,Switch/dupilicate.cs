using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class dupilicate
    {
        public static void duplicate()
        {


            int[] a = new int[] { 1, 2, 3, 4, 2, 7, 8, 8, 3 };

            Console.WriteLine("Duplicate elements is: ");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        Console.WriteLine(a[j]);
                }
            }
        }
    }
}

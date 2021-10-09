using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class factorial
    {
        public void Fact()
        {
            int i, fact = 1, number;
            Console.WriteLine("enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
                fact = fact * i;
            {
                Console.WriteLine("Factorial of " + number + "is:"+fact);
            }
        }
    }
}

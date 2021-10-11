using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class palindrome
    {
        public void Pali()
        {
            string s, revs = "";
            Console.WriteLine("Enter the string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome ");
            }
            Console.ReadKey();
        }
    }
}


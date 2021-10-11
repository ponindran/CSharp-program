using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace If_While_For_Switch
{
    class wordsreverse
    {
        public static void main()
        {
         
            string str = "my name is pon indran";
            string res = string.Join(" ", str.Split(' ').Select(s => new String(s.Reverse().ToArray())));
            Console.WriteLine(res);
        }
    }
}

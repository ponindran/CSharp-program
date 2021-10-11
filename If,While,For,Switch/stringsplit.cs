using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class stringsplit
    {
        public void split()
        {
            string s1 = "cool vs hot";
            string[] s2 = s1.Split(' ');
            foreach(string s3 in s2) 
            {
                Console.WriteLine(s3);
            }
        }
    }
}

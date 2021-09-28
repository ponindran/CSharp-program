using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class @if
    {
        public int If()
            {

                 
                int i;
                Console.Write("enter the number:");
                i = Convert.ToInt32(Console.ReadLine());
                if (i % 2 == 0)
                
                {
                   Console.WriteLine("It is a even number");
                } 
                else
                {
                   Console.WriteLine("It is odd number");
                       
                }
            
            return i;
           }
    }
}

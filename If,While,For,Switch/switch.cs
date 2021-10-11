using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class @switch
    {
        public void Switch()
        {
            int day;
            
            Console.WriteLine("Enter the number:");
            day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Sunday");
                    break;
            }
        }
    }
}
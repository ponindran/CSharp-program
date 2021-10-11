using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class switch_month
    {
        public void month()
        {
            int month;
            Console.Write("enter the num:");
            month = Convert.ToInt32(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.Write("january");
                    break;
                case 2:
                    Console.Write("february");
                    break;
                case 3:
                    Console.Write("march");
                    break;
                case 4:
                    Console.Write("april");
                    break;
                case 5:
                    Console.Write("may");
                    break;
                case 6:
                    Console.Write("june");
                    break;
                case 7:
                    Console.Write("july");
                    break;
                case 8:
                    Console.Write("augest");
                    break;
                case 9:
                    Console.Write("september");
                    break;
                case 10:
                    Console.Write("october");
                    break;
                case 11:
                    Console.Write("november");
                    break;
                case 12:
                    Console.Write("december");
                    break;
            }
        
        }
    }
}

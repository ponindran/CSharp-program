using System;
using System.Collections.Generic;
using System.Text;

namespace If_While_For_Switch
{
    class calculator
    {
        public void Calculator()
        {
            int num1, num2, opt;
            
           Console.WriteLine("\t\tCalculator\n");
            Console.Write("Enter the first num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the second num2:");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOptions:");
            Console.WriteLine("          1.Addition");
            Console.WriteLine("          2.Substraction");
            Console.WriteLine("          3.Multipilication");
            Console.WriteLine("          4.Division");
            Console.WriteLine("          5.exit\n");
            
                
            do
            {
                Console.Write("\nyour choice:");
                opt = int.Parse(Console.ReadLine());
                
                switch (opt)
                {
                    case 1:
                        Console.Write(num1 + num2);
                        break;
                    case 2:
                        Console.Write(num1 - num2);
                        break;
                    case 3:
                        Console.Write(num1 * num2);
                        break;
                    case 4:
                        Console.Write(num1 / num2);
                        break;
                    case 5:
                        break;
                }


            } while (opt <5);

        }
    }
}

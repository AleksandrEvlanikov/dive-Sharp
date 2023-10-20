using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diveСSharp
{
    //Написать программу-калькулятор, вычисляющую выражения вида a + b, a - b, a / b, a* b,
    //введенные из командной строки, и выводящую результат выполнения на экран.


    public class Dz1
    {
         public static void dz1()
        {
            Console.WriteLine("Input number a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input number b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sign: ");
            string sing = Console.ReadLine();

            double result = 0;

            if (sing == "+")
            {
                result = a + b;
                Console.WriteLine($"{a} + {b} = {result}");
                
            }

            if (sing == "-")
            {
                result = a - b;
                
                Console.WriteLine($"{a} - {b} = {result}");
            }

            if (sing == "*")
            {
                result = a * b;
                Console.WriteLine($"{a} * {b} = {result}");
            }

            if (sing == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("you can't divide by zero");
                }
                else
                {
                    result = a / b;
                    Console.WriteLine($"{a} / {b} = {result}");
                    
                }

            }

        }       
    }
}

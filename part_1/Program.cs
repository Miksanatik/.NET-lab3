using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in range -5 <= x <= 9\nX = ");
            double number = 0;
            double result = 0;
            if(Double.TryParse(Console.ReadLine(), out number))
            {
                if (number >= -5 && number <= 9)
                {

                    if (number >= -5 && number < -3)
                    {
                        result = (number + 3.0) * Math.Tan(Math.PI / 4);
                    }
                    else if (number >= -3 && number < 0)
                    {
                        result = Math.Sqrt(9 - Math.Pow(number, 2));
                    }
                    else if (number >= 0 && number < 6)
                    {
                        result = -0.5 * number + 3;
                    }
                    else if (number >= 6 && number <= 9)
                    {
                        result = (number - 6.0) * Math.Tan(Math.PI / 4);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect number. Correct number is >= -5 and <= 9");
                    return;
                }
                Console.WriteLine("F(x) = {0}", result);
            }
        }
    }
}

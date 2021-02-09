using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //inital values
            double x1 = 1;
            double x2 = 4;
            double step = 0.15;
            double epsilon = 0.001;

            //output exp which calculated with iteration method with 
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine(" argument |       result    | steps |  Math.Exp()  ");
            Console.WriteLine("----------------------------------------------------");

            int quantity = (int)((x2 - x1) / step);
            for(int i = 0; i <= quantity; i++)
            {
                double result = 0;
                int steps = 0;
                calculate(x1, epsilon, out steps, out result);
                Console.WriteLine(" {0:0.00000}  |  {1:0.000000000000} | {2:00}    | {3:0.000000000000} ", x1, result, steps, Math.Exp((-1 * Math.Pow(x1, 2))));
                x1 += step;
            }


            
            
        }
        public static void calculate(double number, double accuracy, out int steps,out double result)
        {
            double nextElement = 1.0;
            result = nextElement;
            steps = 0;

            for (; Math.Abs(nextElement) > accuracy; steps++)
            {
                nextElement *= number * number;
                nextElement /= (steps+1);
                result += nextElement;
            }
            result = 1 / result;
        }
    }
}

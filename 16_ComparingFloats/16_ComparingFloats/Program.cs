using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        { 

            bool equal;

            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double maxNum = Math.Max(firstNumber, secondNumber);
            double minNum = Math.Min(firstNumber, secondNumber);

            double eps = maxNum - minNum;

            if(eps >= 0.000001)
            {
                equal = false;
            }
            else
            {
                equal = true;
            }
            Console.WriteLine(equal);
        }
    }
}

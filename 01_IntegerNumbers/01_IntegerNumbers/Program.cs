using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_IntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //-100
            //128
            //- 3540
            //64876
            //2147483648
            //- 1141583228
            //- 1223372036854775808

            sbyte firstNumber = -100;
            byte secondNumber = 128;
            short thirdNumber = -3540;
            int fourthNumber = 64876;
            uint fifthNumber = 2147483648;
            int sixthNumber = -1141583228;
            long seventhNumber = -1223372036854775808;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
            Console.WriteLine(sixthNumber);
            Console.WriteLine(seventhNumber);

        }
    }
}

using System;
using System.Numerics;

namespace _19_IntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //bigint

            BigInteger number = BigInteger.Parse(Console.ReadLine());

            if(number<=long.MaxValue && number>=long.MinValue)
            {
                Console.WriteLine("{0} can fit in: ", number);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", number);
            }

            if(number<=sbyte.MaxValue && number>=sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (number <= byte.MaxValue && number >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            if (number <= short.MaxValue && number >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (number <= ushort.MaxValue && number >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }
            if (number <= int.MaxValue && number >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (number <= uint.MaxValue && number >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }
            if (number <= long.MaxValue && number >= long.MinValue)
            {
                Console.WriteLine("* long");
            }
        }
    }
}

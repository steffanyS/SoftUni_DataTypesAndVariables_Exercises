﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_HexBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string hex = (Convert.ToString(number, 16)).ToUpper();
            string binary = (Convert.ToString(number, 2)).ToUpper();
            Console.WriteLine(hex);
            Console.WriteLine(binary);

        }
    }
}

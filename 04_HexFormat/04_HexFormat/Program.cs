﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(number, 16));
        }
    }
}

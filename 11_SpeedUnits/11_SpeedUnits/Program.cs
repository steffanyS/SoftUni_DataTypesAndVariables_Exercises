﻿using System;

namespace _11_SpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = (int)(hours * 3600 + minutes * 60 + seconds);

            float metersPerSec = (float)meters / time;
            float kilometersPerHour = ((float)meters / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)meters / 1609) / ((float)time / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSec);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);
        }
    }
}

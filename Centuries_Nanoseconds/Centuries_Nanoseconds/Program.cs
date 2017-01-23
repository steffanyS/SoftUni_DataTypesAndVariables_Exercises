using System;
using System.Numerics;

namespace Centuries_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            // years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60;
            BigInteger seconds = (BigInteger)minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microseconds = milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}

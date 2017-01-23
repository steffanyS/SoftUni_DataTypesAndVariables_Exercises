using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine().ToLower();
            if(boolean=="true")
            {
                Console.WriteLine("Yes");
            }
             if(boolean=="false")
            {
                Console.WriteLine("No");
            }
        }
    }
}

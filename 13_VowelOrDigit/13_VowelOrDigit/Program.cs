using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            
            if((char)symbol-'0'==0 || (char)symbol - '0' == 1 || (char)symbol - '0' == 2 || (char)symbol - '0' == 3
                || (char)symbol - '0' == 4 || (char)symbol - '0' == 5 || (char)symbol - '0' == 6 || (char)symbol - '0' == 7
                || (char)symbol - '0' == 8 || (char)symbol - '0' == 9)
            {
                Console.WriteLine("digit");
            }

            else if(symbol=='a' || symbol == 'e' || symbol == 'o' || symbol == 'i' || symbol == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}

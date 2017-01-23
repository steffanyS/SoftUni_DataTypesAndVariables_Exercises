using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            //First name: Amanda
            //Last name: Jonson
            // Age: 27
            //Gender: f
            //Personal ID: 8306112507
            //Unique Employee number: 27563571

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            decimal id = decimal.Parse(Console.ReadLine());
            decimal uin = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName} \n Last name: {lastName} \n Age: {age} \n Gender: {gender} \n Personal ID: {id} \n Unique Employee number: {uin}");
        }
    }
}

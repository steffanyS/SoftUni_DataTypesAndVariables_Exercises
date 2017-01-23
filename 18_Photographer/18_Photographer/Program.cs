using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPictures = (int)Math.Ceiling(n * ((double)filterFactor / 100));
            long totalTime = n * filterTime + filteredPictures * uploadTime;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            string str;
            if (time.Days < 10)
            {
                str = time.ToString(@"d\:hh\:mm\:ss");
            }
            else
            {
                str = time.ToString(@"dd\:hh\:mm\:ss");
            }

            Console.WriteLine(str);
           
        }
    }
}

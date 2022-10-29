using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_3_Хамитова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            int s=a*b;
            while (s >= 0)
            {
                i++;
                s =s-c*c*(i);
            }
            Console.WriteLine("всего {0} С раз поместится в AB", i);
            Console.ReadKey();
        }
    }
}

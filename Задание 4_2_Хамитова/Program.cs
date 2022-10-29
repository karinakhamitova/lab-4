using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4_2_Хамитова
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int n;
            do
            {
                n =Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    i++;
                    Console.WriteLine("Положительных - {0}, отрицательных - {1}",i,j);
                }
                else
                {
                    j++;
                    Console.WriteLine("Положительных - {0}, отрицательных - {1}", i, j);
                }

            } while (n != 0);
            Console.WriteLine("Цикл завершен");
            Console.ReadKey(); 
        }
    }
}

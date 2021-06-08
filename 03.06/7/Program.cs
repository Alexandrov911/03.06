using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.53 б
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 20);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = mas[i]/2;

                }
                else
                {
                    mas[i] = mas[i] * 2;
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}

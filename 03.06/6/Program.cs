using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.53 a
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
                if (i % 10 == 0)
                {
                    mas[i] = 0;
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();

        }
    }
}

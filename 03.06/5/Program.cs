using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //11.52 в
            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b");
            int b = Convert.ToInt32(Console.ReadLine());
            int n = 10;
            int[] mas = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(1, 100);
                Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    mas[i] = mas[i] + a;
                }

                else
                {
                    mas[i] = mas[i] - b;
                }
                Console.WriteLine(mas[i]);
            }
            Console.ReadKey();
        }
    }
}

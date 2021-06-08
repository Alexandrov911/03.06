using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._55б
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.55б
            Console.WriteLine("a");
            int a = Convert.ToInt32(Console.ReadLine());

            int n = 10;
            int[] mas = new int[n];
            int sum = 0;
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-20, 20);
                Console.WriteLine(mas[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (mas[i] % a == 0)

                {
                    sum = sum + mas[i];
                }
            }
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}

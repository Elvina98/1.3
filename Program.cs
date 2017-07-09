using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Введите количество элементов в массиве:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Введите последовательность:");
            for (i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Неотрицательные элементы:");
            for (i = 0; i < n; i++)
            {
                if (a[i] >= 0)
                    Console.WriteLine(a[i] + ", его индекс " + i);
                Console.ReadKey();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            int a = 10;
            int b = 6;

            Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            Console.WriteLine("Hasil pengurangan {0} - {1} = {2}" , a, b, Pengurangan(a,b));
            Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}

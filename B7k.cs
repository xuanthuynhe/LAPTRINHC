using System;

namespace FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so nguyen khong am:");
            int n = int.Parse(Console.ReadLine());

            long factorial = CalculateFactorial(n);

            Console.WriteLine($"Giai thua cua {n} la: {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
using System;

namespace PerfectNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so nguyen:");
            int n = int.Parse(Console.ReadLine());

            bool isPerfect = CheckPerfectNumber(n);

            if (isPerfect)
            {
                Console.WriteLine($"{n} la so hoan hao.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so hoan hao.");
            }
        }

        static bool CheckPerfectNumber(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }
    }
}
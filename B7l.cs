using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so nguyen khong am:");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = CheckPrime(n);

            if (isPrime)
            {
                Console.WriteLine($"{n} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to.");
            }
        }

        static bool CheckPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
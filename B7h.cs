using System;

namespace FindLargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu hai:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so thu ba:");
            int num3 = int.Parse(Console.ReadLine());

            int largest = FindLargest(num1, num2, num3);

            Console.WriteLine($"So lon nhat trong ba so la: {largest}");
        }

        static int FindLargest(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
    }
}
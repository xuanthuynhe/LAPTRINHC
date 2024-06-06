using System;

namespace RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap chieu dai hinh chu nhat (don vi: cm):");
            long length = long.Parse(Console.ReadLine());

            Console.WriteLine("Nhap chieu rong hinh chu nhat (don vi: cm):");
            long width = long.Parse(Console.ReadLine());

            long area = length * width;
            long perimeter = 2 * (length + width);

            Console.WriteLine($"Dien tich hinh chu nhat: {area} cm^2");
            Console.WriteLine($"Chu vi hinh chu nhat: {perimeter} cm");
        }
    }
}
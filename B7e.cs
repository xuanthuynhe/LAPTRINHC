using System;

namespace SumOfRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhận vào số nguyên không dấu 4 byte từ người dùng
            Console.Write("Nhap so nguyen khong dau (4 byte): ");
            uint n = uint.Parse(Console.ReadLine());

            // Tính tổng của các số từ 1 đến n
            uint sum = 0;
            for (uint i = 1; i <= n; i++)
            {
                sum += i;
            }

            // In kết quả lên màn hình
            Console.WriteLine("Tong cua cac so tu 1 den {0} là: {1}", n, sum);
        }
    }
}
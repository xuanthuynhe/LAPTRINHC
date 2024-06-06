using System;

namespace SumOfTwoBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhận vào hai số nguyên có dấu 1 byte từ người dùng
            Console.Write("Nhap so nguyen thu nhat (1 byte): ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen thu 2 (1 byte): ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            // Tính tổng của hai số
            sbyte sum = (sbyte)(num1 + num2);

            // In kết quả lên màn hình
            Console.WriteLine("Tong cua {0} và {1} là: {2}", num1, num2, sum);
        }
    }
}
using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhận vào hai số nguyên không dấu từ người dùng
            Console.Write("Nhap so nguyen thu nhat: ");
            uint num1 = uint.Parse(Console.ReadLine());

            Console.Write("Nhap so nguyen thu 2: ");
            uint num2 = uint.Parse(Console.ReadLine());

            // Tính tổng của hai số
            uint sum = num1 + num2;

            // In kết quả lên màn hình
            Console.WriteLine("Tong cua {0} và {1} là: {2}", num1, num2, sum);
        }
    }
}
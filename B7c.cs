using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhận vào số nguyên không dấu 4 byte từ người dùng
            Console.Write("Nhap so nguyen (4 byte): ");
            uint num = uint.Parse(Console.ReadLine());

            // Kiểm tra số đó là chẵn hay lẻ
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} La so chan.", num);
            }
            else
            {
                Console.WriteLine("{0} la so le.", num);
            }
        }
    }
}
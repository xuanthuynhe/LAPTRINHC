using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Thiết lập trang mã UTF-8
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Bang ma UTF-8 (trang ma 65001):");
        Console.WriteLine("-------------------");
        Console.WriteLine("| STT | Ky tu | Ma |");
        Console.WriteLine("-------------------");

        for (int i = 0; i <= 0xFF; i++)
        {
            try
            {
                string character = Encoding.GetEncoding(65001).GetString(new byte[] { (byte)i });
                if (!string.IsNullOrWhiteSpace(character))
                {
                    Console.WriteLine($"| {i:X2} | {character:^5} | {i:X2} |");
                }
            }
            catch (Exception)
            {
                // Bỏ qua các ký tự không hợp lệ
            }
        }

        Console.WriteLine("-------------------");
    }
}
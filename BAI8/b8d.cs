using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap vao mot chuoi ky tu: ");
        string input = Console.ReadLine();

        // Tạo một dictionary để lưu trữ số lần xuất hiện của mỗi ký tự
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        // Duyệt qua từng ký tự trong chuỗi và đếm số lần xuất hiện
        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
            {
                charCount[c]++;
            }
            else
            {
                charCount[c] = 1;
            }
        }

        // In ra kết quả
        Console.WriteLine("Ket qua dem so lan xuat hien cua moi ky tu:");
        foreach (var pair in charCount)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
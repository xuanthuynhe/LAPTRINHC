using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao mot chuoi ky tu:");
        string input = Console.ReadLine();

        int wordCount = CountWords(input);

        Console.WriteLine("So luong tu trong chuoi la: " + wordCount);
    }

    static int CountWords(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
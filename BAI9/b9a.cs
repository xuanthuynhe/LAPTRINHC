using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao mot chuoi ki tu:");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);

        Console.WriteLine("Chuoi dao nguoc la: " + reversed);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bang ma ASCII:");
        Console.WriteLine("-------------------");
        Console.WriteLine("| STT | Ky tu | Ma |");
        Console.WriteLine("-------------------");

        for (int i = 32; i <= 126; i++)
        {
            Console.WriteLine($"| {i - 32:3} | {(char)i:^5} | {i:3} |");
        }

        Console.WriteLine("-------------------");
    }
}
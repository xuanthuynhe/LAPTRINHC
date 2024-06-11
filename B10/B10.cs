using System;

struct Student
{
    public string Name;
    public double Score;
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        Student[] students = new Student[n];

        // Nhập thông tin sinh viên
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin sinh vien {i + 1}:");
            Console.Write("Ten: ");
            students[i].Name = Console.ReadLine();
            Console.Write("Diem: ");
            students[i].Score = double.Parse(Console.ReadLine());
        }

        // In thông tin sinh viên và tính điểm trung bình
        double totalScore = 0;
        Console.WriteLine("\nThong tin sinh vien:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ten: {students[i].Name}, Diem: {students[i].Score}");
            totalScore += students[i].Score;
        }

        double averageScore = totalScore / n;
        Console.WriteLine($"\nDiem trung binh cua ca lop: {averageScore:F2}");
    }
}
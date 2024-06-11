using System;
using System.IO;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap noi dung de ghi vao file:");
            string content = Console.ReadLine();

            Console.WriteLine("Nhap ten file:");
            string fileName = Console.ReadLine();

            // Ghi nội dung vào file
            WriteToFile(fileName, content);

            // Đọc nội dung từ file và hiển thị
            string readContent = ReadFromFile(fileName);
            Console.WriteLine("Noi dung ten file:");
            Console.WriteLine(readContent);
        }

        static void WriteToFile(string fileName, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.Write(content);
                }
                Console.WriteLine("Da ghi noi dung vao file thanh cong!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
            }
        }

        static string ReadFromFile(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    return reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi: {ex.Message}");
                return null;
            }
        }
    }
}

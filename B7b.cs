using System;

namespace RectangleAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhận vào chiều dài và chiều rộng của hình chữ nhật
            Console.Write("Nhap chieu dai (cm): ");
            ushort length = ushort.Parse(Console.ReadLine());

            Console.Write("Nhap chieu rong (cm): ");
            ushort width = ushort.Parse(Console.ReadLine());

            // Tính diện tích và chu vi của hình chữ nhật
            ushort area = (ushort)(length * width);
            ushort perimeter = (ushort)((length + width) * 2);

            // In kết quả lên màn hình
            Console.WriteLine("Dien tich la: {0} cm²", area);
            Console.WriteLine("Chu vi la: {0} cm", perimeter);
        }
    }
}

using System;

namespace KiemTraTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào 3 số từ bàn phím
            Console.WriteLine("Enter a, b, c:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            // Kiểm tra xem 3 số có là cạnh của một tam giác không
            bool laTamGiac = KiemTraTamGiac(a, b, c);
            Console.WriteLine("a, b, c have sides of a triangle: " + laTamGiac);

            if (laTamGiac)
            {
                // Kiểm tra xem tam giác có là tam giác cân không
                bool laTamGiacCan = KiemTraTamGiacCan(a, b, c);
                Console.WriteLine("a, b, c have sides of a sosceles triangle: " + laTamGiacCan);

                // Kiểm tra xem tam giác có là tam giác đều không
                bool laTamGiacDeu = KiemTraTamGiacDeu(a, b, c);
                Console.WriteLine("a, b, c have sides of a equilateral triangle: " + laTamGiacDeu);

                // Kiểm tra xem tam giác có là tam giác vuông không
                bool laTamGiacVuong = KiemTraTamGiacVuong(a, b, c);
                Console.WriteLine("a, b, c have sides of a rectangle triangle: " + laTamGiacVuong);

                // Kiểm tra xem tam giác có là tam giác vuông cân không
                bool laTamGiacVuongCan = KiemTraTamGiacVuongCan(a, b, c);
                Console.WriteLine("a, b, c have sides of a isosceles right triangle: " + laTamGiacVuongCan);
            }

            Console.ReadLine();
        }

        // Hàm kiểm tra xem 3 số có là cạnh của một tam giác không
        static bool KiemTraTamGiac(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Hàm kiểm tra xem tam giác có là tam giác cân không
        static bool KiemTraTamGiacCan(double a, double b, double c)
        {
            return a == b || b == c || a == c;
        }

        // Hàm kiểm tra xem tam giác có là tam giác đều không
        static bool KiemTraTamGiacDeu(double a, double b, double c)
        {
            return a == b && b == c;
        }

        // Hàm kiểm tra xem tam giác có là tam giác vuông không
        static bool KiemTraTamGiacVuong(double a, double b, double c)
        {
            double max = Math.Max(Math.Max(a, b), c);
            if (max == a)
                return a * a == b * b + c * c;
            else if (max == b)
                return b * b == a * a + c * c;
            else
                return c * c == a * a + b * b;
        }

        // Hàm kiểm tra xem tam giác có là tam giác vuông cân không
        static bool KiemTraTamGiacVuongCan(double a, double b, double c)
        {
            return KiemTraTamGiacCan(a, b, c) && KiemTraTamGiacVuong(a, b, c);
        }
    }
}

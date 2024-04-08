using System;

namespace TinhThuongNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  salary of employee:");
            double luong = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter hours per month:");
            int gioLamViec = int.Parse(Console.ReadLine());

            double thuong = TinhThuong(luong, gioLamViec);

            Console.WriteLine("Bonus of employee is: " + thuong);

            Console.ReadLine();
        }

        static double TinhThuong(double luong, int gioLamViec)
        {
            if (gioLamViec >= 200)
            {
                // Thưởng = 20% lương
                return 0.2 * luong;
            }
            else if (gioLamViec >= 100 && gioLamViec < 200)
            {
                // Thưởng = 10% lương
                return 0.1 * luong;
            }
            else
            {
                // Không thưởng
                return 0;
            }
        }
    }
}

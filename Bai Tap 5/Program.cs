using System;

namespace KiemTraSoNgayTrongThang
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập tháng từ bàn phím
            Console.WriteLine("Enter month (1-12):");
            int thang = int.Parse(Console.ReadLine());

            // Kiểm tra số ngày trong tháng
            int soNgay = 0;
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    soNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgay = 30;
                    break;
                case 2:
                    soNgay = KiemTraNamNhuan() ? 29 : 28;
                    break;
                default:
                    Console.WriteLine("Month is invalid.");
                    return;
            }

            Console.WriteLine(" " + thang + " has " + soNgay + " days.");

            Console.ReadLine();
        }

        // Hàm kiểm tra năm nhuận
        static bool KiemTraNamNhuan()
        {
            Console.WriteLine("Enter year:");
            int nam = int.Parse(Console.ReadLine());
            return (nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0);
        }
    }
}

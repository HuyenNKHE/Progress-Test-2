using System;

namespace KiemTraSo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Nhập số N từ bàn phím
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());

            // 2. Kiểm tra N có phải số nguyên không
            bool isInteger = KiemTraSoNguyen(n);
            Console.WriteLine("N is Integer: " + isInteger);

            // 3. Kiểm tra tính chẵn lẻ của N
            bool isEven = KiemTraChanLe(n);
            Console.WriteLine("N is Even: " + isEven);

            // 4. Kiểm tra N có phải số chẵn dương không
            bool isPositiveEven = KiemTraChanDuong(n);
            Console.WriteLine("N is PositiveEven: " + isPositiveEven);

            // 5. Kiểm tra N có phải số khảm không
            bool isPalindrome = KiemTraKhong(n);
            Console.WriteLine("N is Palindrome: " + isPalindrome);

            // 6. Kiểm tra N có phải số chính phương không
            bool isPerfectSquare = KiemTraChinhPhuong(n);
            Console.WriteLine("N is PerfectSquare: " + isPerfectSquare);

            // 7. Kiểm tra N có phải số Armstrong không (Nếu 0 < N < 1000)
            if (n > 0 && n < 1000)
            {
                bool isArmstrong = KiemTraArmstrong(n);
                Console.WriteLine("N is Armstrong: " + isArmstrong);
            }

            Console.ReadLine();
        }

        // Hàm kiểm tra N có phải số nguyên không
        static bool KiemTraSoNguyen(int n)
        {
            return n % 1 == 0;
        }

        // Hàm kiểm tra tính chẵn lẻ của N
        static bool KiemTraChanLe(int n)
        {
            return n % 2 == 0;
        }

        // Hàm kiểm tra N có phải số chẵn dương không
        static bool KiemTraChanDuong(int n)
        {
            return n > 0 && n % 2 == 0;
        }

        // Hàm kiểm tra N có phải số khảm không
        static bool KiemTraKhong(int n)
        {
            string s = n.ToString();
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        // Hàm kiểm tra N có phải số chính phương không
        static bool KiemTraChinhPhuong(int n)
        {
            int sqrt = (int)Math.Sqrt(n);
            return sqrt * sqrt == n;
        }

        // Hàm kiểm tra N có phải số Armstrong không
        static bool KiemTraArmstrong(int n)
        {
            int sum = 0;
            int originalNumber = n;
            while (n > 0)
            {
                int digit = n % 10;
                sum += (int)Math.Pow(digit, 3); // Số Armstrong là tổng lập phương của các chữ số
                n /= 10;
            }
            return sum == originalNumber;
        }
    }
}

using System;

namespace KiemTraKyTu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập một ký tự từ bàn phím
            Console.WriteLine("Enter a char:");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Kiểm tra ký tự là nguyên âm, phụ âm, ký số (ký tự số) hay ký tự khác
            if (char.IsLetter(ch))
            {
                if (KiemTraNguyenAm(ch))
                {
                    Console.WriteLine(ch + " is vowel.");
                }
                else
                {
                    Console.WriteLine(ch + " is consonant.");
                }
            }
            else if (char.IsDigit(ch))
            {
                Console.WriteLine(ch + " is digit.");
            }
            else
            {
                Console.WriteLine(ch + " is other char.");
            }

            Console.ReadLine();
        }

        // Hàm kiểm tra ký tự là nguyên âm hay không
        static bool KiemTraNguyenAm(char ch)
        {
            ch = char.ToLower(ch); // Chuyển đổi ký tự thành chữ thường để so sánh
            return ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u';
        }
    }
}

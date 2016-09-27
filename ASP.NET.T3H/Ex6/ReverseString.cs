using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class ReverseString
    {
        public static string ReverseStrings(string s)
        {
            char[] arr = s.ToCharArray(); // chuỗi thành mảng ký tự
            Array.Reverse(arr); // đảo ngược mảng
            return new string(arr); // trả về chuỗi mới sau khi đảo mảng
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap chuoi:");
            string a = Console.ReadLine();
            string b = ReverseStrings(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenHuuTien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TinhTongStartEndCach1(3, 10));
            Console.WriteLine(TinhTongStartEndCach2(3, 10));
            Console.WriteLine(TinhTongLe(4, 7));   
            BangCuuChuong(5);
            Console.ReadKey();
        }

        public static int TinhTongStartEndCach1(int start, int end)
        {
            if (start == end) return start;
            return TinhTongStartEndCach1(start, end - 1) + end;
        }

        public static int TinhTongStartEndCach2(int start, int end)
        {
            List<int> list = new List<int>();
            for (int i = start; i <= end; i++) list.Add(i);
            return list.Sum();
        }

        public static int TinhTongLe(int start, int end)
        {
            int tong = 0;
            int newStart = (start % 2 == 1) ? start : (start + 1);
            for (int i = newStart; i <= end; i += 2)
            {
                tong += i;
            }
            return tong;
        }

        public static void BangCuuChuong(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
            }
        }
    }
}

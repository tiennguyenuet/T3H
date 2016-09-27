using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class BangCuuChuong
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bang Cuu Chuong:");
            int num, so_nhan;
            num = 3;
            do
            {
                so_nhan = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}", num, so_nhan, num * so_nhan);
                    so_nhan++;
                }
                while (so_nhan <= 9);
                Console.WriteLine();
                num++;
            } while (num == 3);
            Console.ReadKey();
        }
    }
}

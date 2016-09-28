using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap he so a:");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap he so b:");
            float b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 && b == 0)
                Console.WriteLine("Phuong trinh co vo so nghiem!!!");
            else if (a == 0 && b != 0)
                Console.WriteLine("Phuong trinh vo nghiem!!!");
            else if (a != 0)
            {
                float result = -b / a;
                Console.WriteLine("Phuong trinh co nghiem la x=" + result);
                result.ToString();

            }
            Console.ReadLine();
        }
    }
}

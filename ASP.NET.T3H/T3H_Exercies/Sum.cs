using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3H_Exercies
{
    class Sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Ban hay nhap so bat dau:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ban hay nhap so ket thuc:");
            int finished = Convert.ToInt32(Console.ReadLine());
            for (int i = start; i <= finished; i++)
            {
                sum += i;
            }
            Console.WriteLine("Tong la:" + sum);
            Console.ReadLine();
        }
    }
}

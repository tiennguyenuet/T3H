using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class ListPrime
    {
        //public static bool IsPrime(int num)
        //{
        //    if (num == 1) return false;
        //    if (num == 2) return true;
        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //        if (num % i == 0) return false;
        //    return true;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Ban hay nhap so bat dau:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ban hay nhap so ket thuc:");
            int finished = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= finished; i++)
            {
                if (Ex4.CheckPrime.IsPrime(i))
                    Console.Write("{0}  ", i);              
            }
            Console.ReadKey();

        }
    }
}

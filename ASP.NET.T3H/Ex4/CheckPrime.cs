using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class CheckPrime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap so:");
            int num = Convert.ToInt32(Console.ReadLine());

            //bool kt = IsPrime(num);

            //if (kt == true) Console.WriteLine("So " + num + " la so nguyen to");
            //else Console.WriteLine("So " + num + " khong la so nguyen to");
            Console.WriteLine("{0} {1}", num, IsPrime(num) ? "la so nguyen to" : "khong phai la so nguyen to");
            Console.ReadLine();
        }

        public static bool IsPrime(int num)
        {
            if (num == 1) return false;

            if (num == 2) return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
    }
}

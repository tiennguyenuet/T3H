using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaySoNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            StartMenu(ref arr);
        }

        public static void StartMenu(ref ArrayList arr)
        {
            Console.WriteLine("Phep tinh tren day so nguyen");
            Console.WriteLine("*******************************");
          
            Console.WriteLine("1.Tong day so\n2.Tong cac so le trong day \n3.Tong cac so chan trong day \n4.Thoat");

            int check = int.Parse(Console.ReadLine());
            switch (check)
            {
                case 1:
                    Console.WriteLine("Chon phep tinh 1");
                    CalSumArray(ref arr);
                    Console.Clear();
                    StartMenu(ref arr);
                    break;
                case 2:
                    Console.WriteLine("Chon phep tinh 2");
                    CalSumOdd(ref arr);
                    Console.Clear();
                    StartMenu(ref arr);
                    break;
                case 3:
                    Console.WriteLine("Chon phep tinh 3");
                    CalSumEven(ref arr);
                    Console.Clear();
                    StartMenu(ref arr);
                    break;
                default:
                    break;

            }
        }

        public static void CalSumEven(ref ArrayList arr)
        {
            if (arr.Count == 0)
                Input(arr);

            int sumEven = 0;
            foreach (int i in arr)
                if (i % 2 == 0)
                    sumEven += i;
            Output(arr);
            Console.WriteLine("\nTong cac so le trong day vua nhap la:{0}", sumEven);
        }

        private static void CalSumOdd(ref ArrayList arr)
        {
            if (arr.Count == 0)
                Input(arr);

            int sumOdd = 0;
            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    sumOdd += i;
                }
            }
            Output(arr);
            Console.WriteLine("\nTong cac so le trong day vua nhap la:{0}", sumOdd);
        }

        private static void CalSumArray(ref ArrayList arr)
        {
            
          
            if (arr.Count == 0)
                Input(arr);

            if (arr.Count != 0)
            {
                Console.WriteLine("Ban co muon nhap lai day so khong? Chon Y de nhap lai.Chon phim bat ky de tiep tuc.");
                string check = Console.ReadLine();
                if (check.ToUpper() == "Y") Input(arr);
            }

            int sum = 0;
            foreach (int i in arr)
                sum += i;
            

            Output(arr);
            Console.WriteLine("\nTong cua day so vua nhap: {0}", sum);

        }

        private static void Input(ArrayList arr)
        {
            Console.WriteLine("Nhap so luong phan tu:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                arr.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine();

        }

        private static void Output(ArrayList arr)
        {
            Console.Write("Day so vua nhap");
            foreach(int i in arr){
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession02_Age_Average
{
    class StudentAverage
    {
        static void Main(string[] args)
        {
            ArrayList arrStudent = new ArrayList();
            while (true)
            {
                Console.WriteLine("Nhap ten sinh vien:");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap diem ky I");
                byte k1 = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Nhap diem ky II");
                byte k2 = Convert.ToByte(Console.ReadLine());

                Student st = new Student(name, k1, k2);    
                arrStudent.Add(st);

                Console.Clear();
                Console.WriteLine("     Ten Sinh vien         Diem ky I   Diem ky II  Diem TB  Do/Truot");
                foreach (Student i in arrStudent)
                {
                    i.print();
                }

                Console.WriteLine("Nhan enter de tiep tuc. Nhan Q de thoat");
                string check = Console.ReadLine();
                if (check.ToUpper() == "Q") break;

            }
            Console.ReadLine();
          
           




        }
    }
}

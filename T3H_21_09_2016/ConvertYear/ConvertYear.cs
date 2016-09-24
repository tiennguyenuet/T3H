using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertYear
{
    class ConvertYear
    {
        static void Main(string[] args)
        {
            ArrayList arrYear = new ArrayList();
            while (true)
            {
                Console.WriteLine("Nhap vao nam can tim:");
                int year = Convert.ToInt32(Console.ReadLine());

                Year y = new Year(year);
                arrYear.Add(y);

                Console.Clear();
                Console.WriteLine("Nam duong lich        Nam am lich C1         Nam am lich C2");
                foreach (Year i in arrYear)  i.print();

                Console.WriteLine("Nhan enter de tiep tuc. Nhan Q de thoat");
                string check = Console.ReadLine();
                if (check.ToUpper() == "Q") break;

            }
        }
    }
}

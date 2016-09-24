using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession02_CalculationElectric
{
    class CalculationElectric
    {
        static void Main(string[] args)
        {
            ArrayList arrCus = new ArrayList();
            float[] arrPrice = new float[] { 1.484f, 1.533f, 1.786f, 2.242f, 2.503f, 2.587f };
            while (true)
            {
                Console.WriteLine("Nhap ten khach hang:");
                string name = Console.ReadLine();
                Console.WriteLine("Nhap so dien tieu thu:");
                int numE = Convert.ToInt32(Console.ReadLine());

                Customer cus = new Customer(name, numE,arrPrice);
                arrCus.Add(cus);

                Console.Clear();
                Console.WriteLine("             Ten KH       So dien TT     Muc thu     Thanh tien");
                foreach (Customer c in arrCus)
                {
                    c.print();
                }

                Console.WriteLine("Nhan enter de tiep tuc. Nhan Q de thoat");
                string check = Console.ReadLine();
                if (check.ToUpper() == "Q") break;

            }
        }
    }
}

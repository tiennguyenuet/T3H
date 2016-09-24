using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession02_CalculationElectric
{
    class Customer
    {
        private string name;
        private int numberElec;
        private float  priceElec;

        public Customer(string name, int numE,float[] arrPrice)
        {
            this.name = name;
            this.numberElec = numE;
            if (numE >= 0 && numE <= 50) this.priceElec = arrPrice[0];
            else if (numE > 50 && numE <= 100) this.priceElec = arrPrice[1];
            else if (numE > 100 && numE <= 200) this.priceElec = arrPrice[2];
            else if (numE > 200 && numE <= 300) this.priceElec = arrPrice[3];
            else if (numE > 300 && numE <= 400) this.priceElec = arrPrice[4];
            else this.priceElec = arrPrice[5];
        }

        public float calMoney()
        {
            return priceElec * numberElec;
        }

        public void print()
        {
           Console.WriteLine("{0,20} {1,12} {2,15}{3,10}",name,numberElec,priceElec,calMoney());
        }
        
    }
}

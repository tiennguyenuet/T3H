using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertYear
{
    class Year
    {
        private int valYear;
        
        public Year(int val)
        {
            this.valYear = val;
        }

        //c1:
        public string convertYearToString()
        {
            string res = String.Empty;
            int tmp=valYear;
            int checkA=tmp%10;
            int checkB = tmp % 12;
            switch (checkA)
            {
                case 0:
                    res = "Canh";
                    break;
                case 1:
                    res = "Tan";
                    break;
                case 2:
                    res = "Nham";
                    break;
                case 3:
                    res = "Quy";
                    break;
                case 4:
                    res = "Giap";
                    break;
                case 5:
                    res = "At";
                    break;
                case 6:
                    res = "Binh";
                    break;
                case 7:
                    res = "Dinh";
                    break;
                case 8:
                    res = "Mau";
                    break;
                case 9:
                    res = "Ky";
                    break;
                default:
                    break;

            }

            switch (checkB)
            {
                case 0:
                    res += " Than";
                    break;
                case 1:
                    res += " Dau";
                    break;
                case 2:
                    res += " Tuat";
                    break;
                case 3:
                    res += " Hoi";
                    break;
                case 4:
                    res += " Ti";
                    break;
                case 5:
                    res += " Suu";
                    break;
                case 6:
                    res+= " Dan";
                    break;
                case 7:
                    res += " Mao";
                    break;
                case 8:
                    res += " Thin";
                    break;
                case 9:
                    res += " Ti";
                    break;
                case 10:
                    res += " Ngo";
                    break;
                case 11:
                    res += " Mui";
                    break;
                default:
                    break;

            }
            
            return res;
        }

        //c2:
        public string convert()
        {
            string res;
            string[] can = new string[] {"Canh","Tan","Nham","Quy","Giap","At","Binh","Dinh","Mau","Ky"};
            string[] chi = new string[] { " Than", " Dau", " Tuat", " Hoi", " Ti", " Suu", " Dan", " Mao"," Thin"," Ti", " Ngo", " Mui" };
            return res = can[valYear % 10]+chi[valYear%12];
        }
       
        public void print()
        {
            Console.WriteLine("{0,10} {1,20} {2,20}",valYear,convert(),convertYearToString());
        }
       
    }
}

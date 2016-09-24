using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession02_Age_Average
{
    class Student
    {
        private string name;
        private byte point1;
        private byte point2;

        public string Name { get { return name; } set { name = value; } }

        //public Student()
        //{

        //}
        public Student(string name, byte p1, byte p2)
        {
            this.name = name;
            this.point1 = p1;
            this.point2 = p2;
        }

        public float calAveragePoint()
        {
            return (point1 + point2) / 2;
        }

        public string isPass()
        {
            return calAveragePoint() >= 5 ? "Do" : "Truot";
        }

        public void print()
        {
            Console.WriteLine("{0,20} {1,10} {2,10} {3,10} {4,10}", name, point1, point2, calAveragePoint(), isPass());
        }

    }
}

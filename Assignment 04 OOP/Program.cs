using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment_04_OOP.Duration;

namespace Assignment_04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            ////_3D_Point P = new _3D_Point(10,10,10);
            //// Console.WriteLine(P.ToString());

            //_3D_Point[] points = new _3D_Point[]      
            //{
            //    new _3D_Point(7,4,3), //It work
            //    new _3D_Point(7,4,3),
            //    //new _3D_Point(3,9,2)

            //};
            //Array.Sort(points);
            //foreach(_3D_Point point in points) {Console.WriteLine(point);}

            #endregion

            #region Part02

            //int x = 10; int y = 5;

            //Console.WriteLine(Maths.Add(x, y));
            //Console.WriteLine(Maths.Subtract(x,y)); 
            //Console.WriteLine(Maths.Multiply(x,y));
            //Console.WriteLine(Maths.Divide(x, y));

            #endregion

            #region Part 03
            Time D1 = new Time(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Time D2 = new Time(3600);
            Console.WriteLine(D2.ToString());

            Time D3 = new Time(7800);
            Console.WriteLine(D3.ToString());

            #endregion
        }
    }
}

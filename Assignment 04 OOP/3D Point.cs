using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_OOP
{
    public class _3D_Point :ICloneable, IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        
        public object Clone()
        {
            return new 
            {
                X = this.X,
                Y = this.Y,
                Z = this.Z
            };
        }

        public int CompareTo(object obj)
        {
            _3D_Point point=(_3D_Point)obj;
            if (X > point.X)
                return 1;
            else if (X < point.X)
                return -1;
            else
            {
                if (Y > point.Y)
                    return 1;
                else if (Y < point.Y)
                    return -1; 
                    else
                        return 0;
                
            }

        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }


        public _3D_Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}

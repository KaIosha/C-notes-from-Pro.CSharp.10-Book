using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType__RefType
{
    internal class PointRef
    {
        public int X; public int Y;
        public PointRef(int x,int y)
        {
            this.X = x; this.Y = y;
        }

       public void Display()
        {
            Console.WriteLine($"X={X} , Y={Y}");
        }
    }
}

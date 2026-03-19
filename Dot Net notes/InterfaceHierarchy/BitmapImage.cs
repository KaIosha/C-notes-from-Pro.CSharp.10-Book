using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    internal class BitmapImage:IAdvancedDraw
    {
        public int SideLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int NumberOfSides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }
        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing in a box...");
        }
        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }
    }
}

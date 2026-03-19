using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    internal class Triangle : Shape, IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }
        public string PropName 
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public byte Points => 3; 


        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Triangle", PetName);
        }

        public byte GetNumberOfPoints()
        {
            throw new NotImplementedException();
        }
    }
}

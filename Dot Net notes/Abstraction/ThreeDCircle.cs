using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class ThreeDCircle : Circle
    {

        /*
         Member shadowing (also called "hiding") occurs when a derived (child) class defines 
         a member that has the exact same name as a member in its base (parent) class
.        It is the logical opposite of method overriding.
         While overriding replaces the parent's logic polymorphically,
         shadowing simply "hides" the parent's version behind the child's version
.   
         */


        //public override void Draw()
        //{
        //    Console.WriteLine("Drawing {0} 3D Circle",PetName);
        //}
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D Circlee");
        }
    }
}

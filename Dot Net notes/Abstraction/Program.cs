using Shapes;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Version one 
            //Console.WriteLine("***** Fun with Polymorphism *****\n");
            //Hexagon hex = new Hexagon("Beth");
            //hex.Draw();
            //Circle cir = new Circle("Cindy");
            //// Calls base class implementation!
            //cir.Draw();
            //Console.ReadLine(); 
            #endregion

            //    Console.WriteLine("***** Fun with Polymorphism *****\n");
            //    // Make an array of Shape-compatible objects.
            //    Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"),
            //                        new Circle("Beth"), new Hexagon("Linda")
            //                        };
            //    ThreeDCircle o = new ThreeDCircle();
            //    o.Draw();

            //    ((Shape)o).Draw();


            //    foreach (Shape s in myShapes)
            //    {
            //        s.Draw();
            //    }
            //    Console.ReadLine();
            //}


            //In shadowing, the version that runs depends on the type of the reference variable you are using, not just the object in memory
            ThreeDCircle circle = new ThreeDCircle(); //out: Drawing a 3D Circlee
            Circle circle1 = new Circle();//Drawing NoName the Circle
            Circle circle2 = new ThreeDCircle();//Drawing NoName the Circle
            circle2.Draw();
        }
    }
}

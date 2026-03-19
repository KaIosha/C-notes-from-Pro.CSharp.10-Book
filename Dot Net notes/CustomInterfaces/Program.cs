
namespace CustomInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Passing interface as a parameter 
            //Shape[] shapes = {new Hexagon(),new Circle(),new Triangle("Joe") ,new Circle("JOJO")};
            //for (int i=0; i< shapes.Length;i++)
            //{
            //    if (shapes[i] is IDraw3D s)
            //    {
            //        DrawIn3D(s);
            //    }
            //} 
            #endregion


            #region  Interfaces as Return Values
            //Shape[] myShapes = { new Hexagon(), new Circle(),
            //        new Triangle("Joe"), new Circle("JoJo")};

            //var pointy = FindFirstPointyShape(myShapes);
            //Console.WriteLine(pointy?.Points); 
            #endregion


        }



        // interface as a parameter
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

        //interface as a return value
        static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape shape in shapes)
            {
                if (shape is IPointy s)
                {
                    return s;
                }
            }

            return null;
        }
        static void CloneableExample()
        {
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            CloneMe(myStr);
            CloneMe(unixOS);
            static void CloneMe(ICloneable c)
            {
                // Clone whatever we get and print out the name.
                object theClone = c.Clone();
                Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
            }
        }
    }
}

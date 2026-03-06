namespace Struct
{
    internal class Program
    {
        #region Struct
        //struct Point 
        //{
        //    public int X; 
        //    public int Y;

        //    public Point(int x,int y) 
        //    {
        //        this.X = x;
        //        this.Y = y;
        //    }
        //    public void Increment() { X++;Y++; }
        //    public void Decrement() { X--; Y--; }

        //    public void Display()
        //    {
        //        Console.WriteLine($"X={X} , Y={Y}");
        //    }
        //} 
        #endregion

        readonly struct ReadOnlyPoint
        {
           //* public int x; // called field
            public int X { get; }// Call Property 
            public int Y { get; }

            public void Display()
            {
                Console.WriteLine($"X = {X}, Y = {Y}");
            }

            public ReadOnlyPoint(int xPos, int yPos)
            {
                X = xPos;
                Y = yPos;
            }
        }
        static void Main(string[] args)
        {
            //// Point myPoint=new Point();
            ////myPoint.X = 349;
            ////myPoint.Y = 76;
            ////myPoint.Display();

            ////myPoint.Increment();
            ////myPoint.Display();

            //Point p2 = new Point(50, 60);




        }
    }
}

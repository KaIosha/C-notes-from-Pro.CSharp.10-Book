namespace Operatore_OverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 10, Y = 100 };
            Point p2 = new Point() { Y = 100, X = 10 };

            Console.WriteLine(p1.Equals(p2));
            
        }

   
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }


        public static bool operator ==(Point x, Point y)
        { return x.X == y.X && x.Y == y.Y; }

        public static bool operator !=(Point x, Point y)
        { return x.X != y.X || x.Y != y.Y; }


        public override bool Equals(object p)
        {
            if (p is Point point)
                return this.X == point.X && this.Y == point.Y;
            return false;
        }
    }

}

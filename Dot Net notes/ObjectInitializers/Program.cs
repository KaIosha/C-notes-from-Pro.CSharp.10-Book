namespace ObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Obj init
            //// Make a Point by setting each property manually.
            //Point firstPoint = new Point();
            //firstPoint.X = 10;
            //firstPoint.Y = 10;
            //firstPoint.Display();

            //// Or make a Point via a custom constructor.
            //Point anotherPoint = new Point(20, 20);
            //anotherPoint.Display();

            //// Or make a Point using object init syntax.
            //Point finalPoint = new Point(20, 20) { X = 100, Y = 200 };
            //finalPoint.Display(); 
            #endregion

            //Make readonly point after construction
            PointReadOnlyAfterCreation firstReadonlyPoint
                = new PointReadOnlyAfterCreation(20, 20);
            firstReadonlyPoint.DisplayStats();

            // Or make a Point using object init syntax.
            PointReadOnlyAfterCreation secondReadonlyPoint = new PointReadOnlyAfterCreation
            {
                X = 30,
                Y = 30
            };
            secondReadonlyPoint.DisplayStats();

           // const int x; // error should be set value while init

            Console.WriteLine("=> Constant String Interpolation:");
            const string foo = "Foo";
            const string bar = "Bar";
            const string foobar = $"{foo}{bar}";
            Console.WriteLine(foobar);
        }
    }
}

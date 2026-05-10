namespace SimpleDelegate
{
    internal class Program
    {
        public delegate int BinaryOp(int x, int y);
        public delegate int Square(int x);

        static void Main(string[] args)
        {
           SimpleMath simpleMath = new SimpleMath();
            BinaryOp binaryOp = new BinaryOp(simpleMath.Add);
            Square SquareOp = simpleMath.SquareNumber;

            //Console.WriteLine(binaryOp(5,5));
            //Console.WriteLine(SquareOp(5));
            DisplayDelegateInfo(binaryOp);
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            foreach (var item in delObj.GetInvocationList())
            {
                Console.WriteLine("Method Name: {0}", item.Method);
                Console.WriteLine("Type Name: {0}", item.Target);
            }
        }
    }
}

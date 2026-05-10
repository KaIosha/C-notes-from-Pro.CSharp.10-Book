namespace Extention_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Extension Methods *****\n");
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();
            Console.WriteLine(myInt.ReverseDigits());
        }
    }
}

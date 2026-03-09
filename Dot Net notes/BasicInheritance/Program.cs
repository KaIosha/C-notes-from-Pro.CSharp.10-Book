namespace BasicInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Inheritance *****\n");
            // Now make a MiniVan object.
            MiniVan myVan = new MiniVan() { Speed = 10 };
            Console.WriteLine($"My van is going {myVan.Speed} MPH");
            Console.ReadLine();

            
        }
    }
}

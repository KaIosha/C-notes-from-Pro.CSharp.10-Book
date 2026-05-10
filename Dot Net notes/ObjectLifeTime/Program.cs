namespace ObjectLifeTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person person = new Person();

            MulticastDelegate
        }
    }


    public class Person:IDisposable
    {

        private FileStream file;

        public Person()
        {
            file = new FileStream("test.txt", FileMode.OpenOrCreate);
        }

        public void Dispose()
        {
            file.Dispose();
            Console.WriteLine("File closed");
        }
    }
}

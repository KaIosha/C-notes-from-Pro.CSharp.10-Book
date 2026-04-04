namespace IComparable_Infterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var People = new List<Person>() { new Person { Age = 10 }, new Person { Age = 25 }, new Person { Age = 1 }, new Person { Age = 12 } };
            People.Sort();

            foreach (var item in People)
            {
                Console.WriteLine(item.Age);
            }
        }
    }

    //use it to compare between two (object items like {Age , name,etc...})
    //it compare one thing


    // of you want to compare for more than one Use interface  IComparer
    class Person : IComparable
    {
        public int Age { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            if (obj is Person p)
                return this.Age.CompareTo(p.Age);

            throw new ArgumentException("Object is not a Person");
        }
    }
}

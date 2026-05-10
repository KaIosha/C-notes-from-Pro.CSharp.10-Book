namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualityTest();
        }
        static void BuildAnonymousType(string make, string color, int currSp)
        {
            // Build anonymous type using incoming args.
            var car = new { Make = make, Color = color, Speed = currSp };
            // Note you can now use this type to get the property data!
            Console.WriteLine("You have a {0} {1} going {2} MPH", car.Color, car.Make, car.Speed);
            // Anonymous types have custom implementations of each virtual
            // method of System.Object. For example:
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
        static void EqualityTest()
        {
            // Make 2 anonymous classes with identical name/value pairs.
            var firstCar = new
            {
                Color = "Bright Pink",
                Make = "Saab",
                CurrentSpeed = 55
            };
            var secondCar = new
            {
                Color = "Bright Pink",
                Make = "Saab",
                CurrentSpeed = 55,

            };
            // Are they considered equal when using Equals()?
            if (firstCar.Equals(secondCar))
            {
                Console.WriteLine("Same anonymous object!");
            }
            else
            {
                Console.WriteLine("Not the same anonymous object!");
            }
            // Are they considered equal when using ==?
            if (firstCar == secondCar)
            {
                Console.WriteLine("Same anonymous object!");
            }
            else
            {
                Console.WriteLine("Not the same anonymous object!");
            }
            // Are these objects the same underlying type?
            if (firstCar.GetType().Name == secondCar.GetType().Name)
            {
                Console.WriteLine("We are both the same type!");
            }
            else
            {
                Console.WriteLine("We are different types!");
            }
            // Show all the details.
            Console.WriteLine();
            
        }
    }
}

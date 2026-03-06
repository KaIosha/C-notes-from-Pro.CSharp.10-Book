namespace OOP_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Encapsulation: 
                         means hiding the internal data of an object and
                         allowing access to it only through controlled methods.


            Encapsulation provides a way to preserve the integrity of an object’s state data. Rather than defining 
            public fields (which can easily foster data corruption), you should get in the habit of defining private data, 
                    which is indirectly manipulated using one of two main techniques.

                            •	You can define a pair of public accessor (get) and mutator (set) methods.
                            •	You can define a public property.
            */

            #region Using Getter And Setter 
            //Console.WriteLine("***** Fun with Encapsulation *****\n");
            //Employee emp = new Employee("Marvin", 456, 30_000);
            //emp.GiveBouns(1000);
            //emp.DisplayStats();

            //// Use the get/set methods to interact with the object's name.
            //emp.SetName("Marv");
            //Console.WriteLine($"Employee is named: {emp.GetName()}");

            //// Longer than 15 characters! Error will print to console.
            //Employee emp2 = new Employee();
            //emp2.SetName("Xena the warrior princess");
            //Console.ReadLine(); 
            #endregion

            Console.WriteLine("***** Fun with Encapsulation *****\n");
            Employee emp = new Employee("Marvin", 456, 30000);
            emp.GiveBouns(1000);
            emp.DisplayStats();
            // Reset and then get the Name property.
            emp.Name = "Ali";
            Console.WriteLine(emp.Name);


            #region Properties make u use the operators in c# Like:++ --
            /*
                   Using traditional accessor and mutator methods, you would need to write code such as the  following:
                       Employee joe = new Employee();
                       joe.SetAge(joe.GetAge() + 1);


                   if you encapsulate empAge using a property named Age, you are able to simply write this:
                       Employee joe = new Employee();
                       joe.Age++;
              */
            #endregion
        }
    }
}

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a subclass object and access base class functionality.
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            SalesPerson fred = new SalesPerson
            {
                Name = "Fred",
                SalesNumber = 50,
                Age = 31
            };

            #region Using Aggregation  
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //double cost = chucky.GetBenefitCost();
            //Console.WriteLine($"Benefit Cost: {cost}");
            //Console.ReadLine();
            #endregion



            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            // A better bonus system!
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBouns(300);
            chucky.DisplayStats();
            Console.WriteLine();
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBouns(200);
            fran.DisplayStats();
            Console.ReadLine();
        }
    }
}

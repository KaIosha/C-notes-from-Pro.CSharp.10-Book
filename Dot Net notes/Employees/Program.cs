using System.Text;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a subclass object and access base class functionality.
            //Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            //SalesPerson fred = new SalesPerson
            //{
            //    Name = "Fred",
            //    SalesNumber = 50,
            //    Age = 31
            //};
            #region Using Aggregation  
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //double cost = chucky.GetBenefitCost();
            //Console.WriteLine($"Benefit Cost: {cost}");
            //Console.ReadLine();
            #endregion
            #region Some OutPuts 

            //Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            //// A better bonus system!
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //chucky.GiveBouns(300);
            //chucky.DisplayStats();
            //Console.WriteLine();
            //SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            //fran.GiveBouns(200);
            //fran.DisplayStats();
            //Console.ReadLine(); 
            #endregion

            //object[] things = new object[4];
            //things[0] = new Hexagon();
            //things[1] = false;
            //things[2] = new Manager();
            //things[3] = "Last thing";

            #region eplicit casting for objects
            //foreach (var item in things)
            //{
            //    Hexagon testHex = item as Hexagon;

            //    if (testHex != null) { testHex.Draw(); }
            //    else
            //    {
            //        Console.WriteLine("Item is not a hexagon");
            //    }
            //} 
            #endregion

            //int num1 = 10;
            //int num2 = 11;

            //object n1 = ("Hello");
            //object n2 = n1;

            //Console.WriteLine(n1.GetHashCode());
            //Console.WriteLine(n2.GetHashCode());

            // Console.WriteLine(num1.Equals(num2));
            //Console.WriteLine(n1.Equals(n2));
            //Console.WriteLine(n1.GetHashCode());
            //Console.WriteLine(n2.GetHashCode());

            object obj = new object();  
            object obj2= new object();

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            Console.WriteLine(employee2.Equals(employee1));
            Console.WriteLine(obj.Equals(obj2));


        }

        public static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            // A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            // A PtSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PtSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
        }

        public static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!\", emp.Name");
            switch (emp)
            {
                case SalesPerson s:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;


            }
            Console.WriteLine();
        }
    }
}



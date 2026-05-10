using static Delegates.Rectangle;

namespace Delegates
{
    public delegate void RectDelegate(double Width, double Height);

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate And Lambda expression 
            //var emps = new Employee[]
            //{
            //    new Employee{Id=1,Name="Ali",Gender="Male",TotalSalary=65000m },
            //    new Employee{Id=2,Name="Youssef",Gender="Male",TotalSalary=10000m },
            //    new Employee{Id=3,Name="Mona",Gender="Female",TotalSalary=5000m },
            //    new Employee{Id=4,Name="Huda",Gender="Female",TotalSalary=40000m}
            //};

            //var report = new Report();
            //report.ProessEmployeeSalary(emps, TheSalaryGreaterThan60_000);
            //report.ProessEmployeeSalary(emps, delegate (Employee e) { return e.TotalSalary >= 60_000; });// Anounmus delegate
            //report.ProessEmployeeSalary(emps, (Employee e) => e.TotalSalary >= 60_000); // Lambda expression
            //report.ProessEmployeeSalary(emps, e => e.TotalSalary >= 60_000); // more simple way for Lamda expression
            //Console.ReadKey(); 
            #endregion
            #region MultiCast Delegate 
            // Rectangle rect = new Rectangle();
            // RectDelegate obj = rect.Area;
            // obj += rect.Perimeter;

            //obj(10,20);
            // obj -= rect.Perimeter;
            // obj(10, 20); 
            #endregion

        }

        static bool TheSalaryGreaterThan60_000(Employee e) => e.TotalSalary >= 60_000;

    }

    public class Rectangle
    {
        public void Area(double Width, double Height)
        {
            Console.WriteLine($"Area of rectangle is {Width * Height}.");
        }
        public void Perimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter of rectangle is {2 * (Width + Height)}.");
        }
    }
}

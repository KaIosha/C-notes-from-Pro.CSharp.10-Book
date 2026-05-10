using System;


namespace Delegates
{
    public delegate bool CheckForTheSalary(Employee employee);
    public class Report
    {
        //Before using the delegate
        //public void ProcessEmployeeTheSalaryGreaterThan60_000(Employee[] employees)
        //{
        //    Console.WriteLine("======================================================");

        //    foreach (var employee in employees)
        //    {
        //        if (employee.TotalSalary >= 60_000)
        //        {
        //            Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSalary}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}


        //public void ProcessEmployeeTheSalarybetween59_999And30_000(Employee[] employees)
        //{
        //    Console.WriteLine("======================================================");

        //    foreach (var employee in employees)
        //    {
        //        if (employee.TotalSalary <= 60_000 && employee.TotalSalary >=30_000)
        //        {
        //            Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSalary}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}

        //public void ProcessEmployeeTheSalaryLessThan30_000(Employee[] employees)
        //{
        //    Console.WriteLine("======================================================");

        //    foreach (var employee in employees)
        //    {
        //        if (employee.TotalSalary < 30_000 )
        //        {
        //            Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSalary}");
        //        }
        //    }
        //    Console.WriteLine("\n\n");
        //}


        //After The delegate
        public void ProessEmployeeSalary(Employee[] employees, CheckForTheSalary delgCheck)
        {
            Console.WriteLine("======================================================");

            foreach (var employee in employees)
            {
                if (delgCheck(employee))
                {
                    Console.WriteLine($"{employee.Id} | {employee.Name} | {employee.Gender} | {employee.TotalSalary}");
                }
            }
            Console.WriteLine("\n\n");
        }

    }
}


namespace Deep_Dive_In_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Where 
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };

            ////var EvenNumbers = list.Where(x => x % 2 == 0).ToList();
            //var EvenNumbers = list.Where(x => x % 2 == 0);
            //list.Add(10);
            //list.Add(20);
            //list.Add(30);
            //list.Remove(2);

            //foreach (var e in EvenNumbers)
            //{
            //    Console.Write($"{e} ");
            //} 
            #endregion

            #region Select
            //            IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
            //    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            //};

            //            var students = studentList.Select(st =>
            //                new StudentDTO { Name = st.StudentName, Age = st.Age }
            //            );

            //            foreach (var item in students)
            //            {
            //                Console.WriteLine($"Name:{item.Name}  Age:{item.Age}");
            //            } 
            #endregion

            #region Zip

            //to merge two or three together and if size of one is bigger it will take depend on the smaller size

            //String[] colorName = { "Red", "Green", "Blue" };
            //String[] colorHex = { "FF0000", "00FF00", "0000FF" };
            //string[] auther = { "Ali", "Momo" };

            //// IEnumerable<(string,string)> colors = colorName.Zip(colorHex);
            //var colors = colorName.Zip(colorHex)
            //    .Zip(auther,(first,second) =>
            //    $"{first.First} : {first.Second} : Auther {second}");

            //foreach (var color in colors)
            //{
            //    Console.WriteLine(color);
            //}
            #endregion

            #region Reverse 
            //string[] fruits = { "Mango", "Apple", "Kiwi" };

            //var reversed = fruits.Reverse();

            //foreach (string fruit in reversed)
            //{
            //    Console.WriteLine(fruit);
            //}

            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //} 
            #endregion

            #region Pagination  

            //int nPages = (int)Math.Ceiling((decimal)emps.Count() / 3);
            //int currentPage = 1;
            //var page = emps.Take(3);

            //do
            //{
            //    Console.Clear();
            //    int nSkips = ((currentPage - 1) * 3);
            //    page = emps.Skip(nSkips).Take(3);

            //    foreach (var item in page)
            //        Console.WriteLine($"{item.Name}  {item.Salary}");



            //    Console.WriteLine($"\nnumber of Pages: {currentPage} / {nPages}");
            //    var input = Console.ReadKey().Key;

            //    if (input == ConsoleKey.RightArrow)
            //    {
            //        currentPage = Math.Min(currentPage + 1, nPages);

            //    }
            //    else if (input == ConsoleKey.LeftArrow)
            //    {
            //        currentPage = Math.Max(currentPage - 1, 1);

            //    }
            //    else
            //    {
            //        break;
            //    }

            //} while (true); 
            #endregion

            #region GroupBy tolookup 
            //RunGroupBy();  //GroupBy execution is deferred, whereas ToLookup execution is immediate

            #endregion

            #region Range and Repeat
            ////returns a collection of IEnumerable<T> type with specified number of elements and sequential values starting from the first element.
            //var list = Enumerable.Range(20, 3);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////generates a collection of IEnumerable<T> type with specified number of elements and each element contains same specified value.
            //var intCollection = Enumerable.Repeat<int>(10, 10);
            //Console.WriteLine("Total Count: {0} ", intCollection.Count());
            //foreach (int i in intCollection) 
            //    Console.WriteLine($"Value {i}"); 
            #endregion

            #region Aggregate
            //IList<String> strList = new List<String>() { "One", "Two", "Three", "Four", "Five" };

            //var commaSeperatedString = strList.Aggregate((s1, s2) => s1 + ", " + s2);// merge all in one string

            //Console.WriteLine(commaSeperatedString); 
            #endregion

            #region Distinct
            //        IList<Student> studentList = new List<Student>() {
            //    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
            //    new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
            //    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            //};


            //        var distinctStudents = studentList.Distinct(new StudentComparer());

            //        foreach (Student std in distinctStudents)
            //            Console.WriteLine(std.StudentName);
            //    } 
            #endregion

            //    private static void RunGroupBy()
            //    {
            //        Console.WriteLine("Group By Method");
            //        var emps = Repository.LoadEmployees();

            //        //var groups= emps.GroupBy(x => x.Salary);

            //        //foreach (var item in groups)
            //        //{
            //        //    Console.WriteLine(item.Key);
            //        //    foreach (Employee item2 in item)
            //        //    {
            //        //        Console.WriteLine(item2.Name);

            //        //    }
            //        //}

            //        var result = emps
            //.GroupBy(x => x.Salary)
            //.SelectMany(g => g.Select(e => new { g.Key, e.Name }));

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"{item.Key} - {item.Name}");
            //        }
            //    }
        }
    }

}
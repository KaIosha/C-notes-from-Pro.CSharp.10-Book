namespace Some_TOPICS_FROM_ITI_advCourse
{
    internal static class Program
    {
        static object Test()
        {
            var emp = new { Id = 1, Name = "Ali" };
            return emp;
        }

        static void Display(this List<int> collection, Predicate<int> predicate)
        {
            foreach (var item in collection)
            {
                if (predicate(item))
                    Console.WriteLine(item);
            }
        }

        static void PrintMe(this int x)
        { Console.WriteLine(x); }

        /* deferred Execution */  //vs   /* Eager Execution */
        static IEnumerable<T> Filter<T>(this IEnumerable<T> data, Predicate<T> predicate)
        {
           // var list = new List<T>();
            foreach (var item in data)
            {
                if (predicate(item))
                {
                    //list.Add(item);
                    yield return item;
                }
            }
           // return list;
        }    

        
        static void Main(string[] args)
        {
            #region var (implicitly typed local variable) with anynoums obj
            /*            var x = 5; //var not a data type it's a only a keyword

                var emp = new { Id = 1, Name = "Ali" }; *//* make class has these readonly prop*//*
                var emp2 = new { Id = 1, Name = "Ali",Salary =2000 };*//* make class has these readonly prop*//*
                var test =Test();
    */
            #endregion

            #region Extention Methods

            //List<int> list = new List<int> { 1, 3, 5, -4, 5, 0, 100 };
            //list.Display(x => x > 3);

            //int x = 100;
            //x.PrintMe(); 
            #endregion

            #region Eager and deferred execution
            /*Link to read: https://medium.com/@aishakhandev/c-ienumerable-eager-vs-lazy-loading-b4ecb3f32ced*/
            //List<int> ints = new List<int>() { 1, 2, 3, 4, -14, -2, 190 };
            //IEnumerable<int> values = ints.Filter(item => item > 3);



            //foreach (var item in values)
            //    Console.WriteLine(item);

            //ints[1] = 10000;

            //Console.WriteLine("_______After Edit the first item________");

            //foreach (var item in values)
            //    Console.WriteLine(item);

            #endregion
        }
    }
}

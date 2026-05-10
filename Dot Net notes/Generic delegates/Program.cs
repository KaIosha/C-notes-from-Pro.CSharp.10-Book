namespace Generic_delegates
{

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Action Delegate 

            //Action<string> action = (name) => Console.WriteLine($"Hello {name}");
            //action("Youssef");

            //Action<int, int> Add = (n1, n2) => Console.WriteLine(n1 + n2);
            //Add(5 , 5); 
            #endregion

            #region Func Delegate 
            //Func<int, int> power2 = (n) => n * n;
            //Console.WriteLine( power2(5)); 
            #endregion

            Predicate<int> IsEven = (n) => n % 2 == 0;
            Console.WriteLine(IsEven(43));
        }
    }
    
}



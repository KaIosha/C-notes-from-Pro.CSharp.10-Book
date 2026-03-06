namespace Nullable_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Nullable
            //DatabaseReader dr = new DatabaseReader();
            //int? i = dr.numericValue ?? 102;

            /* ??  if the varable which allow null is null that use to asign value directly */

            //bool? b = dr.boolValue;

            //if (i.HasValue)
            //{
            //    Console.WriteLine("Value of 'i' is: {0}", i.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Value of 'i' is undefined.");
            //}

            //if (b != null)
            //{
            //    Console.WriteLine("Value of 'b' is: {0}", b.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Value of 'b' is undefined.");
            //} 
            #endregion

            //int? xx = null;
            //xx = xx ?? 10;

            //Console.WriteLine(xx);

            int[] ints = null;

            Console.WriteLine($"the lenght is {ints?.Length??20}");
        }
        static void LocalNullableVariables()
        {
            //  ? mean this variable may be null without it I can't put null
            int? Interger = null;// write nullable variable 
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[10];

        }
        static void LocalNullableVariablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
    }
}

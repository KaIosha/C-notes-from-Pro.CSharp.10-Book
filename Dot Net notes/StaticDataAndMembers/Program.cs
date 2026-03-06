namespace StaticDataAndMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Test Static Constructor 
            //SavingsAccount s1= new SavingsAccount(50);
            //Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");

            //SavingsAccount.SetInterestRate(.08);
            //Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}");

            //SavingsAccount s2 = new SavingsAccount(100);
            //Console.WriteLine($"Interest Rate is: {SavingsAccount.GetInterestRate()}"); 
            #endregion

           // TimeUtilClass T1 =new TimeUtilClass(); // Error Can't Create instance

            TimeUtilClass.PrintTime();
            TimeUtilClass.PrintDate();

        }
    }
}

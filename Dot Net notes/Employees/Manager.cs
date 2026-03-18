namespace Employees
{
    internal class Manager : Employee
    {
        private int x = 10;
        public int StockOptions { get; set; }

        public class inner
        {
            Manager m = new Manager();
            public void DoWork()
            {
                m.x = 20; // This is now legal!
                Console.WriteLine($"Manager x is: {m.x}");
            }
        }
        public Manager()
        {

        }
        public Manager(string fullName, int age, int empId, float currPay, string ssn, int
numbOfOpts)
            : base(fullName, age, empId, currPay, ssn, PayTypeEnum.Salaried)
        {
            StockOptions = numbOfOpts;
        }


        public override void GiveBouns(float amount)
        {
            base.GiveBouns(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
        }


        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}

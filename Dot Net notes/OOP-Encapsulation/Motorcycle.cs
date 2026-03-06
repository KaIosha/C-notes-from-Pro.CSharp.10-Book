namespace OOP_Encapsulation
{
    internal class Motorcycle
    {
        // we use this  to  
        //1/ access to the current class instance
        //2/ Chaining Constructor Calls Using this to avoid Redundancy

        public string name;
        public int driverIntensity;
        public string driverName;

        //ex 1
        public void SetDriverName(string name) => this.name = name; //using this to don't fall in logical error

        #region Using constructor Chain 
        //ex 2
        // Redundant constructor logic!

        // Bad version
        /*
        public Motorcycle(int intensity)
         {
             if (intensity > 10)
             {
                 intensity = 10;
             }
             driverIntensity = intensity;
         }
         public Motorcycle(int intensity, string name)
         {
             if (intensity > 10)
             {
                 intensity = 10;
             }
             driverIntensity = intensity;
             driverName = name;
         }
        */


        // better one
        //public Motorcycle()
        //{
        //    Console.WriteLine("In default constructor");
        //}
        //public Motorcycle(int intensity) : this(intensity, "")
        //{
        //    Console.WriteLine("In constructor taking an int");
        //}
        //public Motorcycle(string name) : this(0, name)
        //{
        //    Console.WriteLine("In constructor taking a string");
        //}

        //public Motorcycle(int intensity = 0, string name)
        //{
        //    Console.WriteLine("In main constructor");
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        /*
        constructor Flow
        1/Master (take to Arguments)
        2/the other constructor
         */


        // the best version 
        // use the  (Optional Arguments)

        //public Motorcycle(int intensity = 0, string name = "")
        //{
        //    if (intensity > 10)
        //    {
        //        intensity = 10;
        //    }
        //    driverIntensity = intensity;
        //    driverName = name;
        //}

        //static void MakeSomeBikes()
        //{
        //    // driverName = "", driverIntensity = 0
        //    Motorcycle m1 = new Motorcycle();
        //    Console.WriteLine("Name= {0}, Intensity= {1}",
        //    m1.driverName, m1.driverIntensity);
        //    // driverName = "Tiny", driverIntensity = 0
        //    Motorcycle m2 = new Motorcycle(name: "Tiny");
        //    Console.WriteLine("Name= {0}, Intensity= {1}",
        //    m2.driverName, m2.driverIntensity);
        //    // driverName = "", driverIntensity = 7
        //    Motorcycle m3 = new Motorcycle(7);
        //    Console.WriteLine("Name= {0}, Intensity= {1}",
        //    m3.driverName, m3.driverIntensity);
        //} 
        #endregion
    }
}

namespace ValueType__RefType
{
    internal class Program
    {
        //struct Point
        //{
        //    public int X;
        //    public int Y;

        //    public Point(int x, int y)
        //    {
        //        this.X = x;
        //        this.Y = y;
        //    }
        //    public void Increment() { X++; Y++; }
        //    public void Decrement() { X--; Y--; }

        //    public void Display()
        //    {
        //        Console.WriteLine($"X={X} , Y={Y}");
        //    }
        //}
        static void Main(string[] args)
        {
            /*
                value Type : data allocated on the stack can be created 
                             and destroyed quickly, as its lifetime is determined 
                              by the defining scope
             */

            /*
                Ref Type: Heap-allocated data, on the other 
                          hand, is monitored by the .NET Core garbage collector 
                          and has a lifetime that is determined by many factors
             
             */


            /*
                Functionally, the only purpose of System.ValueType is
                 to override the virtual methods defined by 
                System.Object to use value-based versus reference-based semantics.
                 As you might know, overriding is the 
                process of changing the implementation of a 
               virtual (or possibly abstract) method defined within a base 
                 class. The base class of ValueType is System.Object.
                  In fact, the instance methods defined by System.
                    ValueType are identical to those of System.Object.
             */


            /*
             
             •	If a reference type is passed by reference, the callee may change the values of the 
                object’s state data, as well as the object it is referencing.
             •	If a reference type is passed by value, the callee may change the values of the object’s 
                state data but not the object it is referencing.
             
             */
            #region Reference Type
            ////Point p1 = new Point(10,20);
            ////Point p2 = p1;

            ////p1.Display();
            ////p2.Display();


            ////p1.X = 100;
            ////p1.Display();
            ////p2.Display();w

            //PointRef P1 = new PointRef(10, 20);
            //PointRef P2 = P1;

            //P1.Display();
            //P2.Display();

            //P1.X = 50;
            //P1.Display();
            //P2.Display(); 
            #endregion



            #region Passing by Value
            //Console.WriteLine("***** Passing Person object by value *****");
            //Person fred = new Person("Fred", 12);
            //Console.WriteLine("\nBefore by value call, Person is:");
            //fred.Display();

            //SendPersonByValue(fred);
            //Console.WriteLine("\nAfter by value call, Person is:");
            //fred.Display();
            //Console.ReadLine(); 
            #endregion

            #region Passing by Reference
            //Console.WriteLine("***** Passing Person object by reference *****");

            //Person mel = new Person("Mel", 23);
            //Console.WriteLine("Before by ref call, Person is:");
            //mel.Display();
            //SendAPersonByReference(ref mel);
            //Console.WriteLine("After by ref call, Person is:");
            //mel.Display();
            //Console.ReadLine(); 
            #endregion
        }

        //here You make Passig by Value
        /*
         the parmenter is containing the refrence(Address) not the obj
        -- so I can Edit the Values only but I cant Make new object or make him
        ref to new object
         */
        static void SendPersonByValue(Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 99);
        }
        static void SendAPersonByReference(ref Person p)
        {
            p.personAge = 555;
            p = new Person("Nikki", 999);
        }
    }
}

using System.Runtime.ExceptionServices;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //we use tuple when we want to return more than one value from the method
            //تخيل انك بتستخدمها كوسلة نقل 

            //  مش لازم كله نفس ال DT

            //(string, int) tubles = (First: "A", Last: 15);
            ////or
            //var tuble2 = ("B", 16);

            //Console.WriteLine(tubles.Item1.GetType().Name);


            ////2 may named the values 
            //(string First, int Last) tubles2 = ("BBB", 15);
            //Console.WriteLine(tubles2.First);
            ///* note on 2 */
            //(int, int) example = (Custom1: 5, Custom2: 7); //can't access the custom1 an 2
            ////if you want to write the names on the left side you should use (var)

            ////3 nested Tubles
            //var nestedTubles = (1, ("Ali", 20));
            //Console.WriteLine(nestedTubles.Item2);

            //int a, b;
            //TestOut(out a, out b);
            //Console.WriteLine(a + " " + b);


            //1 Pass All data Through Tuples
            var HummanObj = TransportByTubles();
            Console.WriteLine($"My name is: {HummanObj.name} I have {HummanObj.age} Am I Marride {HummanObj.marride} ");

            //2 Switch Expression With Tuples
            Console.WriteLine(RockPaperScissors("rock", "paper"));
        
        }
        static void TestOut(out int num1, out int num2)
        {
            num1 = 10;
            num2 = 20;
        }

        //using tubles to transport data like (out)
        //1 
        static (string name, int age, bool marride) TransportByTubles()
        {
            return ("Youssef", 20, false);
        }
        //Switch Expression With Tuples
        static string RockPaperScissors(string first, string second)
        {
            return (first, second) switch
            {
                ("rock", "paper") => "Paper wins.",
                ("rock", "scissors") => "Rock wins.",
                ("paper", "rock") => "Paper wins.",
                ("paper", "scissors") => "Scissors wins.",
                ("scissors", "rock") => "Rock wins.",
                ("scissors", "paper") => "Scissors wins.",
                (_, _) => "Tie.",
            };
        }


}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// You can write that and write along without write the hole code
using static System.Console;
using static System.DateTime;
/*
 before:
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now.ToShortTimeString());

After:
      public static void PrintTime()
            => WriteLine(Now.ToShortTimeString());

*/



namespace StaticDataAndMembers
{
    // I added static Keyword

    /*you cannot create an instance of the TimeUtilClass using New Keyword*/
    internal static class TimeUtilClass
    {
        public static void PrintTime()
            => Console.WriteLine(DateTime.Now.ToShortTimeString());
        public static void PrintDate()
            => Console.WriteLine(DateTime.Today.ToShortDateString());
    }
}

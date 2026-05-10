using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Extention_Method
{
    internal static class MyExtensions
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}\n",obj.GetType().Name,Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        public static int ReverseDigits(this int i)
        {
            int newNumber = 0;
            while (i > 0)
            {
                newNumber = newNumber*10 + i % 10;
                i/=10;
            }

            return newNumber;
        }
    } 
}

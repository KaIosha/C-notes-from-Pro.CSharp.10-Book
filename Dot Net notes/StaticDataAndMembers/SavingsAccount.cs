using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    internal class SavingsAccount
    {
        #region static Members 
        ///*
        // static data is perfect when you have a value that should be common to all 
        // objects of that category
        // */


        //// without static Keyword =>  currBalance field is allocated for each object
        //public double currrBalance;

        //// is allocated once and shared among all objects of the same class category
        //public static double currInterestRate = .04;

        //public SavingsAccount(double balance)
        //{
        //    currrBalance = balance;
        //}

        //public static void SetInterestRate(double newRate) => currInterestRate = newRate;

        //public static double GetInterestRate() => currInterestRate; 
        #endregion
        #region Static Constuctor  
        //public double currrBalance;
        //public static double currInterestRate;


        //// It will Reset the static member every creation for mew object
        //public SavingsAccount(double balance)
        //{
        //    //currInterestRate = 0.04;
        //    currrBalance = balance;
        //}

        ////The solution is Static Constructor
        //static SavingsAccount()
        //{
        //    Console.WriteLine("In static constructor!");
        //    currInterestRate = 0.04;
        //}



        //public static void SetInterestRate(double newRate) => currInterestRate = newRate;

        //public static double GetInterestRate() => currInterestRate; 
        #endregion

        public double currrBalance;
        public static double currInterestRate;


        // It will Reset the static member every creation for mew object
        public SavingsAccount(double balance)
        {
            //currInterestRate = 0.04;
            currrBalance = balance;
        }

        //The solution is Static Constructor
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor!");
            currInterestRate = 0.04;
        }



        public static void SetInterestRate(double newRate) => currInterestRate = newRate;

        public static double GetInterestRate() => currInterestRate;

    }
}

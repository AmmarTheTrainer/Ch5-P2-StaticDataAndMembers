using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P2_StaticDataAndMembers
{
    class SavingsAccount
    {
        // Instance-level data.
        public double currBalance;

        // A static point of data.
        //public static double currInterestRate;
        public static double currInterestRate = 0.04; // member initializaiton syntax

        // A static constructor!
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor !");
            currInterestRate = 0.04;
        }

        public SavingsAccount(double balance)
        {
           // currInterestRate = 0.04; // this is a static data
            currBalance = balance;
        }

        // Static members to get/set interest rate.
        public static void SetInterestRate(double newRate)
        {
            currInterestRate = newRate;
        }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}

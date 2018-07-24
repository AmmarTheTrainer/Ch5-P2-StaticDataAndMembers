using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P2_StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Static Data *****\n");

            #region Defining Static Field Data

            //SavingsAccount s1 = new SavingsAccount(50);
            //SavingsAccount s2 = new SavingsAccount(100);
            //SavingsAccount s3 = new SavingsAccount(10000.75);

            #endregion


            #region Defining Static Methods


            //SavingsAccount s1 = new SavingsAccount(50);
            //SavingsAccount s2 = new SavingsAccount(100);

            //// Print the current interest rate.
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            //// Make new object, this does NOT 'reset' the interest rate.
            //SavingsAccount s3 = new SavingsAccount(10000.75);
            //Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            #endregion

            #region Defining Static Constructors

            // Make an account.
            SavingsAccount s1 = new SavingsAccount(50);
            
            // Print the current interest rate.
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
            
            // Try to change the interest rate via property.
            SavingsAccount.SetInterestRate(0.08);
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            // Make a second account.
            SavingsAccount s2 = new SavingsAccount(100);
            
            // Should print 0.08...right??
            Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

            #endregion

            Console.ReadLine();
        }
    }
}

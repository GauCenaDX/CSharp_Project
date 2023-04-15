

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BadCall();
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was an exception thrown. " +
                    "Exception caught in Main().");
                Console.WriteLine(ex.Message);
            }
        }

        private static void BadCall()
        {
            int[] age = new int[] { 1, 3, 5 };

            for (int i = 0; i <= age.Length; i++)
            {

                try
                {
                    Console.WriteLine(age[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception caught in BadCall().");
                    Console.WriteLine(ex);
                    Console.WriteLine();
                    //throw;
                    throw new Exception("The error message we sent from " +
                        "BadCall()", ex);
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWAdvancedBreakpoints
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    if (i == 74)
                    {
                        ExceptionGenerator();
                    }
                }
                catch
                {
                    Console.WriteLine("There is an Exception.");
                }
            }
        }

        private static void ExceptionGenerator()
        {
            throw new NotImplementedException();
        }
    }
}
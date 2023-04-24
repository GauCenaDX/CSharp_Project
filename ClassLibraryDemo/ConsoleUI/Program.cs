

using DemoLibrary;
using DemoLibrary.Models;
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

            double result = Calculations.Add(3, 5);
            Console.WriteLine($"The total: {result}");


            PersonModel person = new PersonModel();


            Console.WriteLine();
            Console.WriteLine("End of program.");
        }
    } 
}


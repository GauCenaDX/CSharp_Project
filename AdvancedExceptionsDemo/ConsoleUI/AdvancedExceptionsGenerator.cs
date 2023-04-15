

using System;

namespace ConsoleUI
{
    public static class AdvancedExceptionsGenerator
    {
        public static void SimpleMethod()
        {
            //throw new InvalidOperationException();
            throw new InvalidOperationException("You should not be calling the " +
                "SimpleMethod().");
        }

        public static void NotImplementedMethod()
        {
            throw new NotImplementedException("You forgot to implement me.");
        }

        public static void ComplexMethod(string name)
        {
            if (name.ToLower() == "tim")
            {
                throw new InsufficientMemoryException("Tim is too big for the memory.");
            }
            else
            {
                throw new ArgumentException("The name is not Tim.");
            }
        }
    }
}
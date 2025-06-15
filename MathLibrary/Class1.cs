﻿namespace MathLibrary
{
    public static class Calculator
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");
            return a / b;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
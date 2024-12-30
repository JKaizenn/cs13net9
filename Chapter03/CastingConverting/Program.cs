﻿namespace CastingConverting;

class Program
{
    static void Main(string[] args)
    {
        #region Implicitlyand Explicitly Casting

        int a = 10;
        double b = a; // An int can be safely cast into a double.
        WriteLine($"a is {a}, b is {b}");

        double c = 9.8;
        int d = (int)c; // Compiler gives an error if you do not explicitly cast.
        WriteLine($"c is {c}, d is {d}"); // d loses the .8 part

        #endregion

    }
}

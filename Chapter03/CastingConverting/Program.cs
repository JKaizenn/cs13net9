namespace CastingConverting;

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

        long e = 5_000_000_000;
        int f = (int)e;
        WriteLine($"e is {e:N0}, f is {f:N0}");

        e = long.MaxValue;
        f = (int)e;
        WriteLine($"e is {e:N0}, f is {f:N0}");

        #endregion

        #region Negative Numbers in Binary 

        // Print the header row with "Decimal" and "Binary" aligned using formatting.
        WriteLine("{0,12} {1,34}", "Decimal", "Binary");

        // Print the maximum value of a 32-bit integer (`int.MaxValue`) in decimal and binary.
        // The :B32 format assumes a special formatter for binary representation.
        WriteLine("{0,12} {0,34:B32}", int.MaxValue);

        // Loop from 8 to -8 to display each integer in both decimal and binary formats.
        for (int i = 8; i >= -8; i--)
        {
            // Print the current value of `i` in both decimal and binary formats.
            WriteLine("{0,12} {0,34:B32}", i);
        }

        // Print the minimum value of a 32-bit integer (`int.MinValue`) in decimal and binary.
        WriteLine("{0,12} {0,34:B32}", int.MinValue);

        long r = 0b_101000101010001110100101010101010;

        int s = (int)r;

        Console.WriteLine($"{"r",38:B38} = {r}");

        Console.WriteLine($"{"s",38:B32} = {s}");

        #endregion


    }
}

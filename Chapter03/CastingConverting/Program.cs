using System.Buffers.Text;
using static System.Convert; // To use the ToInt32 method.
using System.Globalization; // To use CultureInfo

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

        WriteLine();

        Console.WriteLine($"{"r",34:B38} = {r}");

        Console.WriteLine($"{"s",34:B32} = {s}");

        #endregion

        WriteLine();
        #region Converting with System.Convert Type

        double g = 9.8;
        int h = ToInt32(g); // A method of System.Convert.
        WriteLine($"g is {g}, h is {h}");

        #endregion

        WriteLine();

        #region Rounding and Rounding Rules

        double[,] doubles = {
        {  9.49,  9.5,  9.51  },
        { 10.49, 10.5, 10.51  },
        { 11.49, 11.5, 11.51  },
        { 12.49, 12.5, 12.51  },
        { -12.49, -12.5, -12.51 },
        { -11.49, -11.5, -11.51 },
        { -10.49, -10.5, -10.51 },
        {  -9.49,  -9.5,  -9.51 }

        };

        WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
        for (int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 3; y++)
            {
                Write($"| {doubles[x, y],6} | {ToInt32(doubles[x, y]),7} ");
            }
            WriteLine("|");
        }
        WriteLine();

        #endregion

        WriteLine();

        #region Taking control of rounding rules

        foreach (double n in doubles)
        {
            WriteLine(format:
            "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
            arg0: n,
            arg1: Math.Round(value: n, digits: 0,
            mode: MidpointRounding.AwayFromZero));
        }

        #endregion

        WriteLine();

        #region Converting from any type to a String
        
        int number = 12;
        WriteLine(number.ToString());
        bool boolean = true;
        WriteLine(boolean.ToString());
        DateTime now = DateTime.Now;
        WriteLine(now.ToString());
        object me = new();
        WriteLine(me.ToString());

        #endregion

        WriteLine();

        #region Converting from a binary object to a string

        // Allocate an array of 128 bytes.
        byte[] binaryObject = new byte[128];

        // Populate the array with random bytes
        Random.Shared.NextBytes(binaryObject);

        WriteLine("Binary Object as bytes:");
        for (int index = 0; index < binaryObject.Length; index++)
        {
            Write($"{binaryObject[index]:X2}");
        }
        WriteLine();

        // Convert the array to Base64 string and output as text.
        string encoded = ToBase64String(binaryObject);
        WriteLine($"Binary Object as Base64: {encoded}");

        #endregion

        #region Base64 for URLs
        // ReadOnlySpan<byte> bytes = ...;
        // string encoded = Base64Url.EncodeToString(bytes);
        #endregion

        WriteLine();

        #region Parsing from strings to numbers or dates and times
        


        #endregion



        




    }
}

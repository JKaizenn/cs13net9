using System.Security.Cryptography.X509Certificates;

namespace Ch03Ex03Operators;

class Program
{
    static void Main(string[] args)
    {
        // Increment and Addition Operators
        int x = 3;
        int y = 2 + ++x;

        // Binary Shift Operators
        int a = 3 << 2;
        int b = 10 >> 2;

        // Bitwise Operators
        int c = 10 & 8;
        int d = 10 | 7;

        WriteLine($"X is {x} Y is {y}\n");
        WriteLine($"A is {a} B is {b}\n");
        WriteLine($"C is {c} D is {d}\n");
        


    }
}

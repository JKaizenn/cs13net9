using System;

namespace Operators
{
    /// <summary>
    /// Demonstrates the usage of various C# operators, including unary, binary,
    /// null-coalescing, assignment, and logical operators.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main entry point of the application.
        /// </summary>
        /// <param name="args">Array of command-line arguments.</param>
        static void Main(string[] args)
        {
            // Unary Operators Demonstration
            #region Exploring unary operators

            // Post-increment: Value of 'a' is assigned to 'b' before incrementing 'a'.
            int a = 3;
            int b = a++;
            Console.WriteLine($"a is {a} and b is {b}"); // Outputs: a is 4 and b is 3

            // Pre-increment: 'c' is incremented first, and then its value is assigned to 'd'.
            int c = 3;
            int d = ++c;
            Console.WriteLine($"c is {c} and d is {d}"); // Outputs: c is 4 and d is 4

            #endregion

            // Binary Arithmetic Operators Demonstration
            #region Exploring binary arithmetic operators

            int e = 11;
            int f = 3;

            // Demonstrating basic arithmetic operations
            Console.WriteLine($"e is {e}, f is {f}");
            Console.WriteLine($"e + f = {e + f}"); // Addition
            Console.WriteLine($"e - f = {e - f}"); // Subtraction
            Console.WriteLine($"e * f = {e * f}"); // Multiplication
            Console.WriteLine($"e / f = {e / f}"); // Division (integer division)
            Console.WriteLine($"e % f = {e % f}"); // Modulus (remainder)

            // Floating-point division example
            double g = 11.0;
            Console.WriteLine($"g is {g:N1}, f is {f}");
            Console.WriteLine($"g / f = {g / f}"); // Floating-point division

            #endregion

            // Assignment Operators Demonstration
            #region Exploring assignment operators

            int p = 6;

            // Demonstrating compound assignment operators
            p += 3; // Equivalent to: p = p + 3;
            p -= 3; // Equivalent to: p = p - 3;
            p *= 3; // Equivalent to: p = p * 3;
            p /= 3; // Equivalent to: p = p / 3;

            #endregion

            // Null-Coalescing Operators Demonstration
            #region Exploring null-coalescing operators

            // A fictional function returning a nullable string
            string? authorName = GetAuthorName();

            // Null-coalescing operator: Assign a default value if 'authorName' is null
            int maxLength = authorName?.Length ?? 30; // Uses 30 if authorName is null

            // Null-coalescing assignment: Assigns "unknown" if authorName is null
            authorName ??= "unknown";

            #endregion

            // Logical Operators Demonstration
            #region Exploring logical operators

            bool q = false;
            bool r = true;

            // Demonstrating AND, OR, and XOR logical operators
            Console.WriteLine("AND | p     | q     ");
            Console.WriteLine($"p   | {r & r,-5} | {r & q,-5} ");
            Console.WriteLine($"q   | {q & r,-5} | {q & q,-5} ");
            Console.WriteLine();
            Console.WriteLine("OR  | p     | q     ");
            Console.WriteLine($"p   | {r | r,-5} | {r | q,-5} ");
            Console.WriteLine($"q   | {q | r,-5} | {q | q,-5} ");
            Console.WriteLine();
            Console.WriteLine("XOR | p     | q     ");
            Console.WriteLine($"p   | {r ^ r,-5} | {r ^ q,-5} ");
            Console.WriteLine($"q   | {q ^ r,-5} | {q ^ q,-5} ");

            #endregion
        }

        /// <summary>
        /// Simulates retrieving an author's name. 
        /// For this example, it always returns null.
        /// </summary>
        /// <returns>A nullable string representing the author's name.</returns>
        static string? GetAuthorName()
        {
            // Placeholder for the actual function logic
            return null; // Example value
        }
    }
}
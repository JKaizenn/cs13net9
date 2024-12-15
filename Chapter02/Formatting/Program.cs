// Formatting 
using System;
using System.Globalization; // To use CultureInfo.

class Program
{
    static void Main()
    {
        /* Set the current culture to US English so that all readers
        see the same output as shown in the book. */
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        int numberOfApples = 12;
        decimal pricePerApple = 0.35M;

        // Correctly formatted output with named arguments
        Console.WriteLine(format: "{0} apples cost {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);

        // Correct assignment of formatted strings
        string formatted = string.Format("{0} apples cost {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);

        Console.WriteLine(formatted); // Display the formatted string.

        // WriteToFile(Formatted); // Writes the string to a file.

        // Three parameter values can use named arguments.
        Console.WriteLine("{0} {1} lived in {2}.",
            arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

        // Four or more parameter values cannot use named arguments.
        Console.WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
            "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

        // String interpolation for cleaner formatting
        Console.WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");
    }
}
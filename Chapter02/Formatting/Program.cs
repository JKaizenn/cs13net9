﻿// Formatting 
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
        WriteLine(format: "{0} apples cost {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);

        // Correct assignment of formatted strings
        string formatted = string.Format("{0} apples cost {1:C}",
            arg0: numberOfApples,
            arg1: pricePerApple * numberOfApples);

        WriteLine(formatted); // Display the formatted string.

        // WriteToFile(Formatted); // Writes the string to a file.

        // Three parameter values can use named arguments.
        WriteLine("{0} {1} lived in {2}.",
            arg0: "Roger", arg1: "Cevung", arg2: "Stockholm");

        // Four or more parameter values cannot use named arguments.
        WriteLine("{0} {1} lived in {2} and worked in the {3} team at {4}.",
            "Roger", "Cevung", "Stockholm", "Education", "Optimizely");

        // String interpolation for cleaner formatting
        WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

        // Format Strings

        string applesText = "Apples";
        int applesCount = 1234;
        string bananasText = "Bananas";
        int bananasCount = 56789;

        WriteLine("");

        WriteLine(format: "{0,-10} {1,6}",
            arg0: "Name", arg1: "Count");

        WriteLine(format: "{0,-10} {1,6:N0}",
            arg0: applesText, arg1: applesCount);

        WriteLine(format: "{0,-10} {1,6:N0}",
            arg0: bananasText, arg1: bananasCount);

        decimal value = 0.325M;
        WriteLine("Currency: {0:C}, Percentage: {0:0.0%}", value);

        // Get input from the user:

        Write("Type your first name and press ENTER:");
        string? firstName = ReadLine();

        Write("Type your age and press ENTER:");
        string age = ReadLine()!;

        WriteLine($"Hello {firstName}, you look good for {age}.");

        // Getting key input from the user:
        Write("Press any key combination: ");
        ConsoleKeyInfo key = ReadKey();
        WriteLine();
        WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
        arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);

        // Passing arguments to a console app:
        

    }
}
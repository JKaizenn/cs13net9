# Notes: 

- What statement can you type in a C# file to discover the compiler and language version?

```csharp
using System;

class Program
{
    static void Main()
    {
        #if NET5_0
        Console.WriteLine("Running on .NET 5.0");
        #elif NET6_0
        Console.WriteLine("Running on .NET 6.0");
        #elif NET7_0
        Console.WriteLine("Running on .NET 7.0");
        #else
        Console.WriteLine("Unknown .NET version");
        #endif

        Console.WriteLine($"C# Language Version: {GetLanguageVersion()}");
    }

    static string GetLanguageVersion()
    {
        // Use C# version-specific features to determine the language version.
#if LANG_VERSION_11
        return "C# 11.0";
#elif LANG_VERSION_10
        return "C# 10.0";
#elif LANG_VERSION_9
        return "C# 9.0";
#else
        return "Unknown C# version";
#endif
    }
}
```
## What are two types of comments in C#?
- There are one line comments which use two "//" and multi line comments which use "*/ */".

## What is the difference between a verbatim string and an interpolated string?

- Verbatim strings are used to represent string literals exactly as they are, without requiring escape sequences for special characters like backslashes (\) or newlines.
  
- Interpolated are used to embed expressions or variables directly within a string, which are evaluated at runtime.

## Why should you be careful when using float and double values?
- When using float and double, you should be cautious because they both represent numbers with limited precision, which can lead to rounding errors in calculations. float has a smaller range and less precision (around 7 digits), while double has a larger range and higher precision (around 15-16 digits). This imprecision makes comparing floating-point numbers for exact equality unreliable. Instead, it’s better to check if the difference between two numbers is within a small tolerance.

## How can you determine how many bytes a type like double uses in memory
- A simple way of finding the memory used from a type is typing something like:
```Console.WriteLine($"double uses {sizeOf(double)}")```

## Why should you use the var keyword?
- The var keyword helps declare local variables. In C#, the var keyword is used for implicit typing when declaring variables. It allows the compiler to determine the type of the variable at compile time based on the value you assign to it. 
  
## What is the newest syntax to create an instance of a class like XmlDocument?
- The newest syntax is target typed new expression. 
Example:```XmlDocument doc = new();```

## Why should you be careful when using the dynamic type?
- Using the dynamic type bypasses compile-time type checking, deferring it to runtime, which can lead to runtime errors and make debugging more difficult. It also introduces performance overhead due to runtime type resolution and removes IntelliSense support, making development less efficient. Use dynamic cautiously, typically for scenarios like working with COM objects, reflection, or deserializing JSON, where types are not known at compile time.

## How do you right align a format string?
- To right-align text in a format string in C#, you can specify a field width with a negative alignment value inside a placeholder.
Example:```Console.WriteLine("{0,10}", "Hello");```

## What character separates arguments for a console app?
- In a console application, arguments passed from the command line are separated by spaces. Each space acts as a delimiter between arguments.


# <u>End of Chapter 2 Notes</u>


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
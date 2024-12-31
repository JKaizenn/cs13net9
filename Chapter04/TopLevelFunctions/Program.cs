namespace TopLevelFunctions;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("* Top-Level functions example");
        WhatsMyNamespace(); // Call the function
    }

    static void WhatsMyNamespace() // Define a local function (should be static)
    {
        WriteLine("Namespace of Program class: {0}", typeof(Program).Namespace ?? "null");
    }
}
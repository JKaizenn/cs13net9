using static System.Console;

/* Do not define a namespace so this class goes in the default
empty namespace just like the auto-generated partial program class.*/

partial class Program
{
        static void WhatsMyNamespace() // Define a local function (should be static)
        {
            WriteLine("Namespace of Program class: {0}", 
                arg0: typeof(Program).Namespace ?? "null");
        }
}

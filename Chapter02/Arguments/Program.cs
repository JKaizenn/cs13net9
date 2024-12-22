namespace Arguments;

class Program
{
    static void Main(string[] args)
    {
        // Number of Arguments:
        WriteLine($"There are {args.Length} arguments");
        foreach (string arg in args)
        {
            WriteLine(arg);
        }

        // Setting options with arguments:
        if (args.Length < 3)
        {
            WriteLine("You must specify two colors and cursor size, e.g.");
            WriteLine("dotnet run red yellow 50");
            return; // Stop running.
        }

        ForegroundColor = (ConsoleColor)Enum.Parse(
            enumType: typeof(ConsoleColor),
            value: args[0], ignoreCase: true);
        
        try
        {
            CursorSize = int.Parse(args[2]);
        }
        catch(PlatformNotSupportedException)
        {
            WriteLine("The current platform foes not support changing the size of the cursor.");

        }
    }
}

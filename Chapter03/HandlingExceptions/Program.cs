namespace HandlingExceptions;

class Program
{
    static void Main(string[] args)
    {
        #region Try Catch 
        WriteLine("Before Parsing");
        Write("What is your age: ");
        string? input = ReadLine();

        if (input is null)
        {
            WriteLine("You did not enter a value so the app has ended.");
            return; //Exit the app.
        }

        try 
        {
            int age = int.Parse(input!);
            WriteLine($"You are {age} years old.");
        }
        catch (OverflowException)
        {
            WriteLine("Your age is a valid number format but it either too big or small.");
        }
        catch (FormatException)
        {
            WriteLine("The age you entered is not a valid number format.");
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }

        WriteLine("After Parsing");

        // Catch using the when keyword
        Write("Enter an amount: ");
        string amount = ReadLine();
        if (string.IsNullOrEmpty(amount)) return;

        try
        {
            decimal amountValue = decimal.Parse(amount);
            WriteLine($"Amount formatted as currency: {amountValue:C}");
        }
        catch (FormatException) when (amount.Contains('$'))
        {
            WriteLine("Amounts cannot use the dollar sign!");
        }
        catch (FormatException)
        {
            WriteLine("Amounts must only contains digits!");
        }

        #endregion

        WriteLine();

        #region Overflow exceptions

        // Checked will see if an overflow occurs and throws an exception.
        checked
        {
            try
            {
                int x = int.MaxValue - 1;
                WriteLine($"Initial Value: {x}");
                x++;
                WriteLine($"After Incrementing: {x}");
                x++;
                WriteLine($"After Incrementing: {x}");
                x++;
                WriteLine($"After Incrementing: {x}");
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed, but I caught the exception!");
            }
        }
        #endregion


        #region Unchecked Statement

        // This method helps disable compile-time checks.
        unchecked
        {
            int y = int.MaxValue + 1;
            WriteLine($"Initial Value {y}");
            y--;
            WriteLine($"After decrement: {y}");
            y--;
            WriteLine($"After decrement: {y}");
        }


        #endregion


    }
}
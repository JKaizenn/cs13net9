namespace IterationStatements;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        while(x < 10)
        {
            WriteLine(x);
            x++;
        } 
        // #region Looping with the do statement

        // string? actualPassword = "Pa$$w0rd";
        // string? password;
        // int attempts = 0;
        // int maxAttempts = 3;

        // do
        // {
        //     Console.Write("Enter your password: ");
        //     password = Console.ReadLine();
        //     attempts++;

        //     if (password == actualPassword)
        //     {
        //         Console.WriteLine("Correct!");
        //         break;
        //     }

        //     if (attempts >= maxAttempts)
        //     {
        //         Console.WriteLine("Too many failed attempts. Access denied.");
        //         break;
        //     }
        // }
        // while (password != actualPassword);
        // #endregion

        #region Looping with the for statement
        for (int y = 1; y <= 10; y ++)
        {
            WriteLine(y);
        }

        WriteLine();

        for (int y = 0; y <= 10; y+= 3)
        {
            WriteLine(y);
        }
        #endregion

        WriteLine();

        #region Looping with the foreach statement
        string[] names = {"Adam", "Barry", "Charlie"};

        foreach(string name in names)
        {
            WriteLine($"{name} has {name.Length} characters.");
        }

        #endregion
    }
}

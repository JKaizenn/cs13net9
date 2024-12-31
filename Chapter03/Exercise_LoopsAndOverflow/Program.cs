using System.Linq.Expressions;

namespace Exercise_LoopsAndOverflow;

class Program
{
    static void Main(string[] args)
    {

        /* This code repeatedely loops through the numbers 0-500 
        and prints it to the console. */
        int max = 500;

        // Stops the overflow from occuring.
        checked
        {
            for (byte i = 0; i < max; i++)
            {
                WriteLine(i);
            }
        }

    }
}

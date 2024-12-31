namespace Exercise_FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        WriteLine("Welcome to FizzBuzz!");

        int max = 100;
        checked
        {
            // Sets i = 1 and increments up to the max.
            for (int i = 1; i <= max; i++)
            {
                // Checks the remainder of 3 and 5 and replaces the number with "FizzBuzz"
                if (i % 3 == 0 && i % 5 == 0)
                {
                    WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                WriteLine("Fizz");  
                }
                else if (i % 5 == 0)
                {
                WriteLine("Buzz");  
                }
                else
                {
                    WriteLine(i);
                }
            }
        }
    }
}

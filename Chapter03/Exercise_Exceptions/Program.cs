namespace Exercise_Exceptions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter two numbers:");
        string number1 = ReadLine(); // Properly invoke ReadLine with ()
        string number2 = ReadLine(); // Properly invoke ReadLine with ()

        Console.WriteLine($"Your numbers are {number1} and {number2}");
    }
}

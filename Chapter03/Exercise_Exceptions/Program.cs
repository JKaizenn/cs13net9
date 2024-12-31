namespace Exercise_Exceptions;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter two numbers between 0-255:");

        try
        {
            // Convert the string inputs to integers
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            // Checks if the user input is between 0-255
            if (input1 >= 0 && input2 >= 0 && input1 <= 255 && input2 <= 255)
            {
                if (input2 != 0) // Ensure no division by zero
                {
                    Console.WriteLine($"Number 1 divided by Number 2 = {input1 / (double)input2}");
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed. Please try again!");
                }
            }
            else
            {
                Console.WriteLine("Your numbers are not in the desired range, try again!");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format. Please enter valid numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

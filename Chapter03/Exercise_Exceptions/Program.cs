namespace Exercise_Exceptions;

using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter two numbers between 0-255:");

        // Converts the string to int
        int input1 = int.Parse(ReadLine()); 
        int input2 = int.Parse(ReadLine()); 

        // Checks if the user input is between 0-255
        if(input1 >= 0  && input2 >= 0 && input1 <= 255 && input2 <= 255)
        {
            WriteLine($"Number 1 divided by Number 2 = {input1 / input2}");
        }
        else 
        {
            WriteLine("Your number is not in the desired range, try again!");
        }
    
    }
}

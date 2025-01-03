Write("Enter a number: ");
string number = ReadLine();

double a = double.Parse(number);
double b = 2.5;
double answer = Add(a, b);

WriteLine($"{a} + {b} = {answer}");
WriteLine("Please Enter to end the app.");
ReadLine();

double Add(double a, double b)
{
    return a + b; // Deliberate Bug
}


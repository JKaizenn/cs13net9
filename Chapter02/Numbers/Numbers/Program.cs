
//Unsigned Integer: A positive whole number or 0.
uint naturalNumber = 23;

//Int is a negative or positive whole number or 0.
int negativeNumber = -23;

//A single precision floating-point number.
//The suffix f is required to compile.
float realNumber = 2.3f;


//A double is a double-precision floating point number. 
//double is the defualt for a number value with a decimal point.
double anotherRealNumber = 2.3;


int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexidecimalNotation = 0x_001E_8480;

//Check if the three variables have the same value.
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexidecimalNotation}");

//Output the variable values in decimal.
Console.WriteLine($"{decimalNotation:N0}");
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexidecimalNotation:N0}");

//Output the variable values in hexidecimal.
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{decimalNotation:X}");

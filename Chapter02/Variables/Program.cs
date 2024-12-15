using System.Xml; //To use XmlDocument.

object height = 1.88; // Storing a double in an object.
object name = "amir"; // Storing a string in an object.
Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; //This gives a compile error!
int length2 = ((string)name).Length; //Cast name to a string.
Console.WriteLine($"{name} has {length2} characters");


// Dynamic Types
dynamic something;

// Storing an array of int values in a dynamic object.
// An array of any type has a Length property.
something = new[] {3, 5, 7};
// Storing an int in a dynamic object.
// int does not have a Length property.
// something = 12;


// Storing a string in a dynamic object.
// string has a Length property.
// something = "Ahmed";

// This compiles but might throw an exception at run-time.
Console.WriteLine($"The length of something is {something.Length}");

// Output the type of the something variable.
Console.WriteLine($"The type of something is {something.GetType()}");


// Delcaring Local Variables

// Local variables must be declared inside of methods, 
// once the method returns, memory is released.

// Examples of assigning valies to local variables:

var int popultion = 67_000_000; //67 Million in UK.
var double weight = 1.88; //in kilograms.
var decimal price = 4.99M;// in pounds sterling.
var string fruit = "Apples"; // string values use double-quotes.
var char letter = 'Z'; // char values use single quotes.
var bool happy = true; //Booleans can only be true or false.

// Create new objects

// Good use of var because it avoids the repeated type
// as shown in the more verbose second statement.
var xml1 = new XmlDocument(); 
XmlDocument xml2 = new XmlDocument();

// Bad use of var because we cannot tell the type, so we
// should use a specific type declaration as shown in the
// second statement.
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// Learning about value types:

/* Value types have memory allocated on the stack automatically. */


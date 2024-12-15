using System;
using System.Xml; // To use XmlDocument.
using System.IO; // To use StreamWriter.
using System.Collections.Generic; // To use List<T>.

class Program
{
    static void Main()
    {
        object height = 1.88; // Storing a double in an object.
        object name = "amir"; // Storing a string in an object.
        Console.WriteLine($"{name} is {height} metres tall.");

        // int length1 = name.Length; // This gives a compile error!
        int length2 = ((string)name).Length; // Cast name to a string.
        Console.WriteLine($"{name} has {length2} characters");

        // Dynamic Types
        dynamic something;

        // Storing an array of int values in a dynamic object.
        // An array of any type has a Length property.
        something = new[] { 3, 5, 7 };

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

        // Declaring Local Variables
        // Local variables must be declared inside of methods, 
        // once the method returns, memory is released.

        // Examples of assigning values to local variables:

        int population = 67_000_000; // 67 Million in UK.
        double weight = 1.88; // In kilograms.
        decimal price = 4.99M; // In pounds sterling.
        string fruit = "Apples"; // String values use double-quotes.
        char letter = 'Z'; // Char values use single quotes.
        bool happy = true; // Booleans can only be true or false.

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

        short age; // Allocates 2 bytes of memory on the stack to store a System.Int16 value.
        long populationLong; // Allocates 8 bytes of memory on the stack to store a System.Int64 value.
        DateTime birthdate; // Allocates 8 bytes of memory on the stack to store a System.DateTime value.
        System.Drawing.Point location; // Allocates memory on the stack to store a System.Drawing.Point value.

        /* Reference types will only have memory allocated on the heap when new is used
        (but they automatically have some memory allocated on the stack to store information
        about themselves including the memory address of where they are on the heap.) */

        Person bob; /* Allocates memory in the stack that can point to a person object in the heap.
        Initially, bob will have the value null. */

        // Using new:
        age = 45; // Initialize this variable to 45 using a literal value.
        populationLong = 68_000_000; // Initialize this variable to 68 million using a literal value.
        birthdate = new DateTime(1995, 2, 23); // Initialize this variable to February 23rd, 1995.
        location = new System.Drawing.Point(10, 20); // Initialize the X and Y coordinates of this value type.
        bob = new(); /* Allocate memory on the heap to store a Person. Any state will have
        default values. Bob will no longer be null. */
        bob = new("Bob", "Smith", 45); /* Allocate memory on the heap to store a Person and initialize state. 
        Bob is no longer null. */

        // Using target-typed new to instantiate objects:
        XmlDocument xml13 = new();

        // This is especially useful with arrays and collections because they have multiple objects.
        List<Person> people = new() // Instead of: new List<Person>()
        {
            new() { FirstName = "Alice" }, // Instead of: new Person() { ... }
            new() { FirstName = "Bob" },
            new() { FirstName = "Charlie" }
        };

        // Default Values:
        Console.WriteLine($"default(int) = {default(int)}");
        Console.WriteLine($"default(bool) = {default(bool)}");
        Console.WriteLine($"default(DateTime) = {default(DateTime)}");
        Console.WriteLine($"default(string) = {default(string) ?? "<NULL>"}");

        int number = 13;
        Console.WriteLine($"number set to {number}");
        number = default;
        Console.WriteLine($"number reset to its default: {number}");
    }

    // Person class definition
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() { }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }
}
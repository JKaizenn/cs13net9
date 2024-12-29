namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        #region arrays

        string[] names; // This can reference any size array of strings.

        // Allocate memory for four strings in an array.
        names = new string[4];

        // Store items at these index positions.
        names[0] = "Kate";
        names[1] = "Jack";
        names[2] = "Rebecca";
        names[3] = "Tom";

        // Alternative syntax for creating and initializing an array.
        string[] names2 = {"Kate", "Jack", "Rebecca", "Tom"};

        // Loop through the names.
        for (int i = 0; i < names2.Length; i++)
        {
            // Output the item at index position i.
            WriteLine($"{names2[i]} is at position {i}.");
        }
        #endregion

        #region multi-dimensional arrays
        string[,] grid1 = // Two dimensional array.
        {
            { "Alpha", "Beta", "Gamma", "Delta" },
            { "Anne", "Ben", "Charlie", "Doug" },
            { "Aardvark", "Bear", "Cat", "Dog" }
        };

        // Discover the lower and upper bounds of this array
        Console.WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
        Console.WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
        Console.WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
        Console.WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

        for (int row = 0; row <= grid1.GetUpperBound(0); row++)
        {
            for (int col = 0; col <= grid1.GetUpperBound(1); col++)
            {
                WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
            }
        }

        /* Alternative syntax for declaring and allocating memory
        for a multi-dimensional array.*/
        string[,] grid2 = new string[3,4]; // Allocate memory.

        grid2[0, 0] = "Alpha"; // Assign values.
        grid2[0, 1] = "Beta";
        // And so on.
        grid2[2,3] = "Dog";
        #endregion


    }
}

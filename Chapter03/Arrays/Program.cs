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

    }
}

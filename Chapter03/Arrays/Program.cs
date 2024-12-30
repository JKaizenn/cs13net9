namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Single-Dimensional Arrays

            string[] names; // This can reference any size array of strings.

            // Allocate memory for four strings in the array.
            names = new string[4];

            // Assign values to the array elements.
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            // Alternative syntax for creating and initializing an array.
            string[] names2 = { "Kate", "Jack", "Rebecca", "Tom" };

            // Loop through the array and display each name with its position.
            for (int i = 0; i < names2.Length; i++)
            {
                // Output the item at index position i.
                WriteLine($"{names2[i]} is at position {i}.");
            }

            #endregion

            #region Multi-Dimensional Arrays

            // Declare and initialize a two-dimensional array.
            string[,] grid1 = 
            {
                { "Alpha", "Beta", "Gamma", "Delta" },
                { "Anne", "Ben", "Charlie", "Doug" },
                { "Aardvark", "Bear", "Cat", "Dog" }
            };

            // Display the bounds of the two-dimensional array.
            WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
            WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
            WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
            WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

            // Loop through each element in the two-dimensional array and display it.
            for (int row = 0; row <= grid1.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= grid1.GetUpperBound(1); col++)
                {
                    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
                }
            }

            // Declare and allocate memory for a two-dimensional array.
            string[,] grid2 = new string[3, 4];

            // Assign values to specific positions in the array.
            grid2[0, 0] = "Alpha";
            grid2[0, 1] = "Beta";
            // Additional values can be added as needed.
            grid2[2, 3] = "Dog";

            #endregion

            #region Jagged Arrays

            // Declare and initialize a jagged array (array of arrays).
            string[][] jagged = 
            {
                new[] { "Alpha", "Beta", "Gamma" },
                new[] { "Anne", "Ben", "Charlie", "Doug" },
                new[] { "Aardvark", "Bear" }
            };

            // Display the upper bound of the jagged array.
            WriteLine($"Upper bound of the array of arrays is: {jagged.GetUpperBound(0)}");

            // Loop through the jagged array to display the bounds of each sub-array.
            for (int array = 0; array <= jagged.GetUpperBound(0); array++)
            {
                WriteLine($"Upper bound of array {array} is: {jagged[array].GetUpperBound(0)}");
            }

            // Loop through each element in the jagged array and display it.
            for (int row = 0; row <= jagged.GetUpperBound(0); row++)
            {
                for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
                {
                    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
                }
            }
            WriteLine();
            #endregion

            #region Pattern Matching with Arrays

            int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] oneTwoNumbers = { 1, 2 };
            int[] oneTwoTenNumbers = { 1, 2, 10 };
            int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
            int[] emptyNumbers = { }; // or use Array.Empty<int>()
            int[] threeNumbers = { 9, 7, 5 };
            int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

            WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}\n");

            WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}\n");

            WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}\n");

            WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}\n");

            WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}\n");

            WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}\n");

            WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}\n");

            WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}\n");

            WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}\n");

            static string CheckSwitch(int[] values) => values switch
            {
                [] => "Empty array",

                [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",

                [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",

                [1, 2] => "Contains 1 then 2.",

                [int item1, int item2, int item3] =>
                    $"Contains {item1} then {item2} then {item3}.",

                [0, _] => "Starts with 0, then one other number.",

                [0, ..] => "Starts with 0, then any range of numbers.",

                [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",

                _ => "Any items in any order.", // <-- Note the trailing comma for easier re-ordering.
            };
            #endregion
        }
    }
}
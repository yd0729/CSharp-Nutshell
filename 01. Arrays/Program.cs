// Arrays

{
    // An array represents a fixed number of elements of a particular type.

    char[] vowels = new char[5]; // Declare an array of 5 characters

    // Square brackets also index the array, accessing a particular element by position:

    vowels[0] = 'a';
    vowels[1] = 'e';
    vowels[2] = 'i';
    vowels[3] = 'o';
    vowels[4] = 'u';
    Console.WriteLine(vowels[1]); // e

    // Array indexes start at 0. We can use a for loop statement to iterate through each element in the array.
    // The for loop in this example cycles the integer i from 0 to 4:

    for (int i = 0; i < vowels.Length; i++)
        Console.Write(vowels[i]); // aeiou
    Console.WriteLine();

    // An array initialization expression:

    char[] easy = { 'a', 'e', 'i', 'o', 'u' };
}

// Default Element Initialization
{
    // Creating an array always preinitializes the elements with default values.
    // For int, this is 0:

    int[] a = new int[1000];
    Console.Write(a[123]); // 0

    // Value Type

    VPoint[] b = new VPoint[1000];
    int x = b[500].X; // 0

    // In contrast, creating an array of reference types allocates null references:

    RPoint[] c = new RPoint[1000];

    for (int i = 0; i < c.Length; i++) // Iterate i from 0 to 999
        c[i] = new RPoint(); // Set array element i with new point

    RPoint[] nulls = new RPoint[1000];
    Console.WriteLine(nulls[0] == null); // True
    Console.WriteLine(nulls[0].X); // Error: NullReferenceException thrown
}

// Multidimensional Arrays - Rectangular
{
    // Rectangular arrays represent an n-dimensional block of memory; jagged arrays are arrays of arrays.

    int[,] matrix = new int[3, 3]; // 2-dimensional rectangular array

    // The GetLength method of an array returns the length for a given dimension (starting at 0):

    for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = i * 3 + j;

    // A rectangular array can be initialized as follows:

    int[,] matrix2 = new int[,]
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 }
    };
}

// Multidimensional Arrays - Jagged
{
    // Here's how to declare a jagged array (an array of arrays):

    int[][] matrix = new int[3][];

    // The inner dimensions aren’t specified in the declaration. Unlike a rectangular array,
    // each inner array can be an arbitrary length. Each inner array is implicitly initialized
    // to null rather than an empty array. Each inner array must be created manually:

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[i] = new int[3]; // Create inner array
        for (int j = 0; j < matrix[i].Length; j++)
            matrix[i][j] = i * 3 + j;
    }

    // A jagged array can be initialized as follows:

    int[][] matrix2 = new int[][]
    {
        new int[] { 0, 1, 2 },
        new int[] { 3, 4, 5 },
        new int[] { 6, 7, 8, 9 }
    };
}

// Simplified Array Initialization Expressions
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    // We can omit the "new" expression after the assignment operator:

    int[,] rectangularMatrix =
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 }
    };

    int[][] jaggedMatrix =
    {
        new int[] { 0, 1, 2 },
        new int[] { 3, 4, 5 },
        new int[] { 6, 7, 8 }
    };
}

// Simplfied Array Initialization with Implicit Typing
{
    // The var keyword tells the compiler to implicitly type a local variable:

    var i = 3; // i is implicitly of type int
    var s = "sausage"; // s is implicitly of type string

    // Therefore:
    var rectMatrix = new int[,] // rectMatrix is implicitly of type int[,]
    {
        { 0, 1, 2 },
        { 3, 4, 5 },
        { 6, 7, 8 }
    };

    var jaggedMat = new int[][] // jaggedMat is implicitly of type int[][]
    {
        new int[] { 0, 1, 2 },
        new int[] { 3, 4, 5 },
        new int[] { 6, 7, 8 }
    };

    // Implicit typing can be taken one stage further with single-dimensional arrays. You can omit
    // the type qualifier after the new keyword and have the compiler infer the array type:

    var vowels = new[] { 'a', 'e', 'i', 'o', 'u' }; // Compiler infers char[]
    var x = new[] { 1, 10000000000 }; // Legal - all elements are convertible to long
}

// Bounds Checking
{
    // All array indexing is bounds-checked by the runtime:

    int[] arr = new int[3];
    arr[3] = 1; // IndexOutOfRangeException thrown
}

public struct VPoint
{
    public int X, Y;
}

public class RPoint
{
    public int X, Y;
}
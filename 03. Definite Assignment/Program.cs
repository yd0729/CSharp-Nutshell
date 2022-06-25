// C#'s Definite Assignment policy means that local variables must be initialized before use.

int x;
// Console.WriteLine(x);        // Compile-time error

// Array elements are automatically initialized:

int[] ints = new int[2];
Console.WriteLine(ints[0]);    // 0

// Fields are automatically initialized:

Console.WriteLine(Test.X);   // 0

class Test { public static int X; }   // field

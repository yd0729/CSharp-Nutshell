// Value Types

{
    // == and != test for equality and inequality of any type, but always return a bool value
    // (unless overloaded otherwise). Value types typically have a very simple notion of equality:

    int x = 1;
    int y = 2;
    int z = 1;

    Console.WriteLine(x == y); // False
    Console.WriteLine(x != y); // True
    Console.WriteLine(x == z); // True

    Console.WriteLine(x < y); // True
    Console.WriteLine(x >= z); // True
}

// Reference Types
{
    // For reference types, equality, by default, is based on reference, as opposed to the 
    // actual value of the underlying object (more on this in Chapter 6).

    Dude d1 = new Dude("John");
    Dude d2 = new Dude("John");
    Console.WriteLine(d1 == d2); // False
    Dude d3 = d1;
    Console.WriteLine(d1 == d3); // True
}

// Conditional Operator
{
    // The conditional operator (also called the ternary operator) has the form
    //    q ? a : b
    // where if condition q is true, a is evaluated, else b is evaluated.
    Console.WriteLine(Max(2, 3));
}

int Max(int a, int b)
{
    return (a > b) ? a : b;
}

public class Dude
{
    public string Name;

    public Dude(string n)
    {
        Name = n;
    }
}
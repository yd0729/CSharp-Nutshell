{
    // To pass by reference, C# provides the ref parameter modifier.
    // In the following example, p and x refer to the same memory locations:

    int x = 8;
    Foo(ref x); // Ask Foo to deal directly with x
    Console.WriteLine(x); // x is now 9
}

{
    // The ref modifier is essential in implementing a swap method:

    string x = "Penn";
    string y = "Teller";
    Swap(ref x, ref y);
    Console.WriteLine(x); // Teller
    Console.WriteLine(y); // Penn
}

static void Foo(ref int p)
{
    p = p + 1; // Increment p by 1
    Console.WriteLine(p); // Write p to screen
}

static void Swap(ref string a, ref string b)
{
    string temp = a;
    a = b;
    b = temp;
}
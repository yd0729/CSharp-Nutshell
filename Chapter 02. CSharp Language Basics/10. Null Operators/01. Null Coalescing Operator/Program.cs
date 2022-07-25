// Null Coalescing Operator

{
    string s1 = null;
    string s2 = s1 ?? "nothing"; // s2 evaluates to "nothing"
}

// Null Coalescing Assignment Operator
{
    string s1 = null;
    s1 ??= "something";
    Console.WriteLine(s1); // something

    s1 ??= "everything";
    Console.WriteLine(s1); // something
}
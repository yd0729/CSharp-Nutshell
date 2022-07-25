// Precedence

{
    // The * operator has higher precedence than + so this expression evaluates to 7:

    var a = 1 + 2 * 3;
    Console.WriteLine(a);
}

// Left Associativity
{
    // For operators of the same precedence, associativity determines order of evaluation.
    // The binary operators (except for assignment, lambda and null coalescing operators) are
    // left-associative; in other words, they are evaluated from left to right:

    var b = 8 / 4 / 2;
    Console.WriteLine(b);
}

// Right Associativity
{
    // The assignment operators, lambda, null coalescing and conditional operator are right-associative:

    int x, y;
    x = y = 3;
    Console.WriteLine(x);
    Console.WriteLine(y);
}
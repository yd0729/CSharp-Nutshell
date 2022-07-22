// You can add the checked keyword to force overflow checking:

int a = 1000000;
int b = 1000000;

// The following code throws OverflowExceptions:

int c = checked(a * b); // Checks just the expression.

// Checks all expressions in statement block:
checked
{
    int c2 = a * b;
}

// Compile-time overflows are special in that they're checked by default:

//int x = int.MaxValue + 1;               // Compile-time error

// You have to use unchecked to disable this:

int y = unchecked(int.MaxValue + 1); // No errors
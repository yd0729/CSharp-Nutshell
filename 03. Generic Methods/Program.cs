// A generic method declares type parameters within the signature of a method.

int x = 5;
int y = 10;

Swap(ref x, ref y);

static void Swap<T>(ref T a, ref T b) // Generic Method ，因为引入了 T
{
    (a, b) = (b, a);
}
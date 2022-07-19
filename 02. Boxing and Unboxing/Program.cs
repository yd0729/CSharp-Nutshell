// 1. Boxing and Unboxing
// Boxing is the act of casting a value-type instance to a reference-type instance;
// unboxing is the reverse.

int x = 9;
object obj = x; // Box the int
int y = (int)obj; // Unbox the int

Console.WriteLine(y);

// 2. Unboxing to Wrong Type
// When unboxing, the types must match exactly:

obj = 9; // 9 is inferred to be of type int
long z = (long)obj; // InvalidCastException

// 3. Fix
// First, unbox to the correct type (int), then implicitly convert to long:

long l = (int)obj;

// This also works:

object obj2 = 3.5; // 3.5 is inferred to be of type double
y = (int)(double)obj2; // x is now 3
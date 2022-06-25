// For each call to Factorial, x gets pushed onto the stack:

Factorial(5);

static int Factorial(int x)
{
	if (x == 0) return 1;
	return x * Factorial(x - 1);
}
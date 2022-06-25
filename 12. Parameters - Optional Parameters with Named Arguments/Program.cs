// Named arguments are particularly useful in conjunction with optional parameters:

Bar(d: 3);

void Bar(int a = 0, int b = 0, int c = 0, int d = 0)
{
	Console.WriteLine(a + " " + b + " " + c + " " + d);
}
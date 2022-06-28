// Constants are factored out at compile-time and baked into the calling site.

Console.WriteLine(Test.Message);

// Here, the calculation is performed at compile-time:

const double twoPI = 2 * System.Math.PI;
Console.WriteLine(twoPI);

public class Test
{
	public const string Message = "Hello World";
}
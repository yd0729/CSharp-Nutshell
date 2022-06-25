{
	// The out modifier is most commonly used to get multiple return values back from a method:

	string a, b;
	Split("Stevie Ray Vaughn", out a, out b);
	Console.WriteLine(a);                      // Stevie Ray
	Console.WriteLine(b);                      // Vaughn
}

{
	// From C# 7, you can declare variables on the fly when calling methods with out parameters.

	Split("Stevie Ray Vaughan", out string a, out string b);
	Console.WriteLine(a);                      // Stevie Ray
	Console.WriteLine(b);                      // Vaughan

	Split("Stevie Ray Vaughan", out string x, out _);   // Discard the 2nd param
	Console.WriteLine(x);
}

void Split(string name, out string firstNames, out string lastName)
{
	int i = name.LastIndexOf(' ');
	firstNames = name.Substring(0, i);
	lastName = name.Substring(i + 1);
}
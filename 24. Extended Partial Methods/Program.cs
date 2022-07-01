// The presence of an accessiblity modifier on a partial method denotes an 'extended partial method'.
// Extended partial methods *must* have implementations:

public partial class Test
{
	public partial void M1();    // Extended partial method
	private partial void M2();   // Extended partial method

	public partial bool IsValid(string identifier);
	internal partial bool TryParse(string number, out int result);
}

public partial class Test
{
	public partial void M1() { }
	private partial void M2() { }

	public partial bool IsValid(string identifier) => !string.IsNullOrEmpty(identifier);
	internal partial bool TryParse(string number, out int result) => int.TryParse(number, out result);
}
// In this example, the set accessors are private while the get accessors are public:

new Foo { X = 5 };      // Will not compile - X has a private set accessor.

public class Foo
{
	private decimal x;
	public decimal X
	{
		get { return x; }
		private set { x = Math.Round(value, 2); }
	}

	public int Auto { get; private set; }   // Automatic property
}
class Program
{
	static void Main()
	{
		SomeBigStruct x = default;

		Foo(x);      // Calls the first overload
		Foo(in x);   // Calls the second overload

		Bar(x);      // OK (calls the 'in' overload)
		Bar(in x);   // OK (calls the 'in' overload)
	}

	static void Foo(SomeBigStruct a) => Console.WriteLine("Foo");
	static void Foo(in SomeBigStruct a) => Console.WriteLine("in Foo");
	static void Bar(in SomeBigStruct a) => Console.WriteLine("in Bar");

	struct SomeBigStruct
	{
		public decimal A, B, C, D, E, F, G;
	}
}
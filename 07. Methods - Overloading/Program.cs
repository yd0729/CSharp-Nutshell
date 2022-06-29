class Program
{
	// We can overload Foo as follows:
	void Func(int x) { Console.WriteLine("int"); }
	void Func(double x) { Console.WriteLine("double"); }
	void Func(int x, float y) { Console.WriteLine("int, float"); }
	void Func(float x, int y) { Console.WriteLine("float, int"); }

	// We have to use a Main() method here to test this,
	// because methods in top-level statements are *local methods*
	// which cannot be overloaded.

	void Main()
	{
		Func(123);       // int
		Func(123.0);     // double
		Func(123, 123F); // int, float
		Func(123F, 123); // float, int
	}

	// The following overloads are prohibited:

	void Foo(int x) { }
    //float Foo(int x) { }           // Compile-time error

    void Goo(int[] x) { }
    //void Goo(params int[] x) { }  // Compile-time error

    void Hoo(int x) { }
	void Hoo(ref int x){ }     // OK so far
    //void Hoo(out int x) { }      // Compile-time error
}
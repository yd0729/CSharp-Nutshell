// Methods, constructors and indexers can declare optional parameters.
// A parameter is optional if it specifies a default value in its declaration:

Foo();		// 23
Foo(23);	// 23  (equivalent to above call)

void Foo(int x = 23) { Console.WriteLine(x); }
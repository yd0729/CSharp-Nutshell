// When you use top-level statements, your methods are implicitly local.
// We can verify this by trying to access a variable outside the method:

int x = 3;
Foo();

// Foo is a local method
void Foo() => Console.WriteLine(x); // We can access x
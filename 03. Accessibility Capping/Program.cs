// A type caps the accessibility of its declared members:

class C						// Class C is implicitly internal
{
    public void Foo() {}	// Foo's accessibility is capped at internal
}

class Program
{
    public static void Main(string[] args)
    {
        
    }
}
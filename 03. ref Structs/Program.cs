class Program
{
    public static void Main(string[] args)
    {
        // var points = new Point [100];    // Error: will not compile!
    }
}

// class MyClass { Point P; }         // Error: will not compile!

// Beginning with C# 7.2, you can use the ref modifier in the declaration of a structure type.
// Instances of a ref struct type are allocated on the stack and can't escape to the managed heap.
ref struct Point { public int X, Y; }


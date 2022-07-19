using System.Text;

// Target-typed new expressions are helpful when the method argument is a constructor call:

MyMethod(new("test"));

void MyMethod(StringBuilder sb)
{
}

// They're also useful when the variable declaration and initialization are in different
// parts of your code:

class Foo
{
    System.Text.StringBuilder sb;

    public Foo(string initialValue)
    {
        sb = new(initialValue);
    }
}
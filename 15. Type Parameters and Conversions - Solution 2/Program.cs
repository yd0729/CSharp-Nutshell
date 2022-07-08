// A more general solution is to first cast to object:

using System.Text;

StringBuilder Foo<T> (T arg)
{
    if (arg is StringBuilder)
        return (StringBuilder) (object) arg;
	
    /*...*/
    return null;
}

// Unboxing conversions can also introduce ambiguities; again the solution is to first cast to object:

int Bar<T> (T x) => (int) (object) x;
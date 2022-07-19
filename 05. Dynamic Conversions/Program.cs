// The dynamic type has implicit conversions to and from all other types:

var i = 7;
dynamic d = i;
long j = d; // Implicit conversion (or more precisely, an *assignment conversion*)

Console.WriteLine(j);

// The following throws a RuntimeBinderException because an int is not implicitly convertible to a short:
short s = d;
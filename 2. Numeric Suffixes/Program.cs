// Numeric literals can be suffixed with a character to indicate their type:
//   F = float
//   D = double
//   M = decimal
//   U = uint
//   L = long
//   UL = ulong

// No suffix needed: Implicit lossless conversion from int literal to long
const long i = 5;     

Console.WriteLine(i);

// The D suffix is redundant in that all literals with a decimal point are inferred to be double:
const double x = 4.0;

Console.WriteLine(x);

// The F and M suffixes are the most useful:
const float f = 4.5F;		// Will not compile without the F suffix
const decimal d = -1.23M;   // Will not compile without the M suffix.

Console.WriteLine(f);
Console.WriteLine(d);
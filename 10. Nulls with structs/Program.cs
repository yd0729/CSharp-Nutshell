// A value type cannot ordinarily have a null value:

Point p = null;     // This line will not compile.
int x = null;	  	// Illegal, too.

public struct Point { public int X, Y; }

// See "Nullable Types" in Chapter 4 for a workaround.
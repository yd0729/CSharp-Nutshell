// A reference can be assigned the literal null, indicating that the reference points to nothing:

Point p = null;
Console.WriteLine(p == null);   // True

// The following line generates a runtime error (a NullReferenceException is thrown) 而且编译时会有警告 :
Console.WriteLine(p.X);

public class Point { public int X, Y; }

// 换成 struct 则会无法编译
// Point p = null;   // This line will not compile.
// int x = null;	 // Illegal, too.

// public struct Point { public int X, Y; }
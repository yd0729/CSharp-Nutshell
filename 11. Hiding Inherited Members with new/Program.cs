// A base class and a subclass may define identical members. This usually happens by accident:

B b = new B();
Console.WriteLine(b.Counter); // 2
	
// Notice the non-virtual behavior in the code below:

A referenceConvertedB = b;
Console.WriteLine(referenceConvertedB.Counter); // 1

public class A      { public int Counter = 1; }
public class B : A  { public int Counter = 2; }  // 没有 new ，编译器会有警告

// Occasionally, you want to hide a member deliberately, in which case you can apply the new  
// modifier to the member in the subclass, to avoid the compiler warning. The behavior is the same:

public class X      { public     int Counter = 1; }
public class Y : X  { public new int Counter = 2; }
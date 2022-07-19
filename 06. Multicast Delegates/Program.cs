// All delegate instances have multicast capability:

SomeDelegate d = SomeMethod1;
d += SomeMethod2;

d();

d -= SomeMethod1;
d();

void SomeMethod1() => Console.WriteLine("SomeMethod1");
void SomeMethod2() => Console.WriteLine("SomeMethod2");

delegate void SomeDelegate();
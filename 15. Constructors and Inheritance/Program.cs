// A subclass must declare its own constructors. In doing so, it can call any of the
// base class’s constructors with the base keyword:

new Subclass (123);

public class Baseclass
{
    public int X;
    public Baseclass () { }
    public Baseclass (int x) { this.X = x; }
}

public class Subclass : Baseclass
{
    public Subclass (int x) : base (x) { }
}
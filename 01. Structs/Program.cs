// A struct is similar to a class, with several key differences (as described in the book).
// In particular, a struct is a value type rather than a reference type.

// The construction semantics are different, too:

Point p1 = new Point ();       // p1.x and p1.y will be 1
Point p2 = new Point (2, 2);   // p2.x and p2.y will be 2

struct Point
{
    public int x, y;
    public Point ()             { this.x = 1; this.y = 1; }
    public Point (int x, int y) { this.x = x; this.y = y; }
    
    // public Point (int x)        { this.x = x; }   // Illegal: y not assigned
}
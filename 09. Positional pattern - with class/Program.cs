Print(new Point(0, 0));
Print(new Point(1, 1));

string Print(object obj)
{
    return obj switch
    {
        Point (0, 0) => "Empty point",
        Point (var x, var y) when x == y => "Diagonal",

        _ => "Other"
    };
}

internal class Point
{
    public readonly int X, Y;

    public Point(int x, int y)
    {
        (X, Y) = (x, y);
    }

    // Here's our deconstructor:
    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }
}
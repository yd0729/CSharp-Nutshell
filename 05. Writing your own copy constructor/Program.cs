var p1 = new Point(3, 4);
var p2 = p1 with { Y = 5 };

internal record Point(double X, double Y)
{
    protected Point(Point original)
    {
        X = original.X;
        Y = original.Y;
    }
}
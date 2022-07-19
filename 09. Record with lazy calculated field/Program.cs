var p1 = new Point(2, 3);
Console.WriteLine(p1.DistanceFromOrigin);

var p2 = p1 with { X = 4 };
Console.WriteLine(p2.DistanceFromOrigin);

// The best solution is to use lazy evaluation.

internal record Point
{
    private double? _distance;

    private readonly double _x;
    private readonly double _y;

    public Point(double x, double y)
    {
        (X, Y) = (x, y);
    }

    public double X
    {
        get => _x;
        init
        {
            _x = value;
            _distance = null;
        }
    }

    public double Y
    {
        get => _y;
        init
        {
            _y = value;
            _distance = null;
        }
    }

    public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X + Y * Y);
}
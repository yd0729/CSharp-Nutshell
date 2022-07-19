var p1 = new Point(2, 3);

internal record Point
{
    // We calculate DistanceFromOrigin just once.
    // This works, but doesn't allow for non-destructive mutation.

    public Point(double x, double y)
    {
        (X, Y, DistanceFromOrigin) = (x, y, Math.Sqrt(x * x + y * y));
    }

    public double X { get; }
    public double Y { get; }
    public double DistanceFromOrigin { get; }
}
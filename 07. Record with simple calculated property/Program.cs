var p1 = new Point(2, 3);
Console.WriteLine(p1.DistanceFromOrigin);

internal record Point(double X, double Y)
{
    // This gets recomputes every time we call it.
    public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y);
}
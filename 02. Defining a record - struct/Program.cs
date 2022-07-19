new Point(2, 3);

// Run the line below to look at Point in ILSpy.
// Util.OpenILSpy (typeof (Point));

record struct Point
{
    public Point(double x, double y) => (X, Y) = (x, y);

    public double X { get; init; }
    public double Y { get; init; }
}
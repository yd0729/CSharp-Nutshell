var p = new Point(2, 3);

record Point
{
    public Point(double x, double y) => (X, Y) = (x, y);

    public double X { get; init; }
    public double Y { get; init; }
}
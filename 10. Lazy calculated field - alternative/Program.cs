var p1 = new Point(2, 3);
Console.WriteLine(p1.DistanceFromOrigin);

var p2 = p1 with { Y = 4 };
Console.WriteLine(p2.DistanceFromOrigin);

// This also works, but is not quite as efficient if we had additional
// properties that weren't part of the calculation.
// 在上一种写法中，编译器自动生成的拷贝构造函数会拷贝所有的字段（所以要在 init 中将 _distance 赋值 null ）。
// 而这种自定义的拷贝构造函数忽略了那些字段，这样写问题就是，如果还有其他的属性，那么他们 cache 的值也会被丢弃。

internal record Point(double X, double Y)
{
    private double? _distance;

    // 拷贝构造函数应该是 Protected
    protected Point(Point other)
    {
        (X, Y) = other;
    }

    public double DistanceFromOrigin => _distance ??= Math.Sqrt(X * X + Y * Y);
}
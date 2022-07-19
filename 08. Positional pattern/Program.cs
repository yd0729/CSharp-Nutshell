var p = new Point(2, 2);

Console.WriteLine(p is (2, 2)); // True
Console.WriteLine(p is var (x, y) && x == y); // True

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

internal record Point(int X, int Y); // Has compiler-generated deconstructor
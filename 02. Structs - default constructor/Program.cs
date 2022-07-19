Point p1 = new Point(); // p1.x and p1.y will be 1
Point p2 = default; // p2.x and p2.y will be 0

// 即使定义了无参构造，下面两种情况仍然会使用 default 初始化
var points = new Point [10]; // Each point in the array will be (0,0)
var test = new Test(); // test.p will be (0,0);

struct Point
{
    public int x = 1;

    public int y;

    // 即使定义了无参构造函数，default 仍可用，并且会将全部字段初始化为默认值
    public Point() => y = 1;
}

class Test
{
    public Point p;
}
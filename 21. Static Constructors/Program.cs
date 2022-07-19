// A static constructor executes once per type, rather than once per instance:

// Type is initialized only once

new Test();
new Test();
new Test();

Console.WriteLine(Foo2.X); // 3

class Test
{
    static Test()
    {
        Console.WriteLine("Type Initialized");
    }
}

// Static field initializers run just before the static constructor is called:

// 1. 静态字段在没有初始化之前有一个默认值。
// 2. 静态字段按照声明的顺序初始化。
// 3. 调用静态构造函数。

class Foo
{
    public static int X = Y; // 0
    public static int Y = 3; // 3
}

class Foo2
{
    public static Foo2 Instance = new Foo2();
    public static int X = 3;

    Foo2() => Console.WriteLine(X); // 0
}
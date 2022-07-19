// #define DEBUG  // 也可在 .csproj 中定义

MyClass mc = new();
mc.Foo();

class MyClass
{
    private int x = 1;

    public void Foo()
    {
#if DEBUG
        Console.WriteLine(x);
#endif
    }
}
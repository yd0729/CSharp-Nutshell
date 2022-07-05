// When calling an overload method, the method with the most specific 
// parameter type match has precedence, based on the *compile-time* variable type:

class Program
{
    public static void Main(string[] args)
    {
        Foo(new House()); // Calls Foo (House)
        // Overload 会调用类型最接近的重载，但这个过程是编译时静态完成的
        // 也就是根据 Reference 的类型来确定，而不是 Value 的类型
        // 但如果 a 是 dynamic 的，那么会在运行时根据 Value 的类型来确定
        Asset a = new House();
        Foo(a); // Calls Foo (Asset)
        Foo((dynamic)a); // Calls Foo(House)
    }

    static void Foo(Asset a)
    {
        Console.WriteLine("Foo Asset");
    }

    static void Foo(House h)
    {
        Console.WriteLine("Foo House");
    }
}

public class Asset
{
    public string Name;
}

public class Stock : Asset // inherits from Asset
{
    public long SharesOwned;
}

public class House : Asset // inherits from Asset
{
    public decimal Mortgage;
}
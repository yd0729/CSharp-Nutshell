public class TopLevel
{
    protected class Nested
    {
    }
}

public class SubTopLevel : TopLevel
{
    static void Foo()
    {
        new TopLevel.Nested();
    }
}

class Program
{
    public static void Main(string[] args)
    {
    }
}
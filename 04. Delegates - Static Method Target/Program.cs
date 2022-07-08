Transformer t = Test.Square;
Console.WriteLine (t(10));      // 100

class Test
{
    public static int Square (int x) => x * x;
}

delegate int Transformer (int x);
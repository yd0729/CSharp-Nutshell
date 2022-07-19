using System.Runtime.CompilerServices;


class Program
{
    // 只是记录一下用法
    [assemly: InternalsVisibleTo("Friend")]
    internal int x = 1;

    public static void Main(string[] args)
    {
    }
}
using System.Reflection;

[assembly: AssemblyFileVersion("1.2.3.4")]

internal class Foo
{
    [field: NonSerialized] public int MyProperty { get; set; }
}

internal class Program
{
    public static void Main(string[] args)
    {
    }
}
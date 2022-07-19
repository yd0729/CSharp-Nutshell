#define DEBUG

using System.Diagnostics;

[Conditional("DEBUG")]
public class TestAttribute : Attribute
{
    public static void Main(string[] args)
    {
    }
}
using System.Runtime.CompilerServices;

Foo();

static void Foo(
    [CallerMemberName] string memberName = null,
    [CallerFilePath] string filePath = null,
    [CallerLineNumber] int lineNumber = 0)
{
    Console.WriteLine(memberName);
    Console.WriteLine(filePath);
    Console.WriteLine(lineNumber);
}
using System.Runtime.CompilerServices;

for (int i = 0; i < 100; i++)
{
    Foo();
}

for (int i = 0; i < 100; i++)
{
    Foo2();
}

[SkipLocalsInit]
unsafe void Foo()
{
    int local;
    int* ptr = &local;

    Console.Write(*ptr + " ");

    int* a = stackalloc int[10];
    for (int i = 0; i < 10; ++i)
    {
        Console.Write(a[i] + " ");
    }

    Console.WriteLine();
}

[SkipLocalsInit]
void Foo2()
{
    Span<int> a = stackalloc int[100];
    for (int i = 0; i < 10; ++i)
    {
        Console.Write(a[i] + " ");
    }

    Console.WriteLine();
}
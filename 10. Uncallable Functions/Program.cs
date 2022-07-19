﻿// You cannot dynamically call:
//  • Extension methods (via extension method syntax)
//  • Any member of an interface
//  • Base members hidden by a subclass

using Microsoft.CSharp.RuntimeBinder;
using Uncapsulator;

IFoo f = new Foo();
dynamic d = f;
try
{
    d.Test(); // Exception thrown
}
catch (RuntimeBinderException error)
{
    Console.WriteLine("You cannot call explicit interface members via dynamic binding");
    Console.WriteLine(error.Message);
}

// A workaround is to use the Uncapsulator library (available on NuGet, and built into LINQPad)
var u = f.Uncapsulate();
u.Test();

internal interface IFoo
{
    void Test();
}

internal class Foo : IFoo
{
    void IFoo.Test()
    {
        Console.WriteLine("Test");
    }
}
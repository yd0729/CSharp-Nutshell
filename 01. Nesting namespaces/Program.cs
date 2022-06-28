Console.WriteLine(typeof (Outer.Middle.Inner.Class1).FullName);

namespace Outer
{
    namespace Middle
    {
        namespace Inner
        {
            class Class1 { }
            class Class2 { }
        }
    }
}

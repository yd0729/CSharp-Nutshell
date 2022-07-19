var f = new Outer.Foo();

namespace Outer
{
    class Foo
    {
    }

    namespace Inner
    {
        class Foo
        {
        }

        class Test
        {
            Foo f1; // = Outer.Inner.Foo
            Outer.Foo f2; // = Outer.Foo
        }
    }
}
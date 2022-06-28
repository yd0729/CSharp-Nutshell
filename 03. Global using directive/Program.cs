// 'global using' directives apply to files in the project.
// (In LINQPad, global usings have the same effect as normal usings.)

global using Outer.Middle.Inner;

Class1 c;    // Don’t need fully qualified name

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
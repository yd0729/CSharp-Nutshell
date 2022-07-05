namespace N
{
	class A
	{
		static void Main()
		{
			new A.B();           // Instantiate nested class B
			new global::A.B();   // Instantiate class B in namespace A
		}

		public class B { }            // Nested type
	}
}

namespace A
{
	class B { }
}
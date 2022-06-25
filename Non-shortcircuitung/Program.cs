// Same examples as before, but with & and | instead of && and ||.
// The results are identical, but without short-circuiting:

using System.Text;

StringBuilder sb = null;

if (sb != null & sb.Length > 0)       // Exception is thrown!
	Console.WriteLine("sb has data");
else
	Console.WriteLine("sb is null or empty");


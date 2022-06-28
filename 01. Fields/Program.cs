// A field is a variable that is a member of a class or struct.

var o = new Octopus();
Console.WriteLine(o);
class Octopus
{
	string name;
	public int Age = 10;
	static readonly int legs = 8, eyes = 1;
}
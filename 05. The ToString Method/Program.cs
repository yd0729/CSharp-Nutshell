// The ToString method is defined on System.Object and
// returns the default textual representation of a type instance:

int x = 1;
string s1 = x.ToString();     // 这里不会发生 boxing
object box = x;
string s2 = box.ToString();  // s2 仍然是 1

Console.WriteLine(s1);
Console.WriteLine(s2);

// You can override the ToString method on custom types:

Panda p = new Panda { Name = "Petey" };
Console.WriteLine (p.ToString()); 		// Petey

public class Panda
{
    public string Name;
    public override string ToString() { return Name; }
}
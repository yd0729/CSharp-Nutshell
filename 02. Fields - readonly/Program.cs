// Readonly fields let you create *immutable* classes.

var o = new Octopus("Jack");
Console.WriteLine(o.Name);
//o.Legs = 20;    // Compile-time error

class Octopus
{
    public readonly string Name;
    public readonly int Legs = 8;

    public Octopus(string name)
    {
        Name = name;
    }
}
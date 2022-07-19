// The same code, but with Panda defined inside a namespace.

using Animals;

Panda p = new Panda("Pan Dee");
Console.WriteLine(p.Name);

namespace Animals
{
    public class Panda
    {
        public string Name;

        public Panda(string n) // Constructor
        {
            Name = n; // Assign the instance field
        }
    }
}
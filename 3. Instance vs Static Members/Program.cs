// The instance field Name pertains to an instance of a particular Panda,
// whereas Population pertains to the set of all Pandas:

using NutShell;

Panda p1 = new("Pan Dee");
Panda p2 = new("Pan Dah");

Console.WriteLine(p1.Name);      // Pan Dee
Console.WriteLine(p2.Name);      // Pan Dah

Console.WriteLine(Panda.Population);   // 2

namespace NutShell
{
    public class Panda
    {
        public string Name;              // Instance field
        private static int population;   // Static field

        public static int Population { get => population; set => population = value; }

        public Panda(string n)         // Constructor
        {
            Name = n;                      // Assign the instance field
            Population++;   // Increment the static Population field
        }
    }
}
// For reference types, equality, by default, is based on reference, as opposed to the 
// actual value of the underlying object (more on this in Chapter 6).

using MyNamespace;

var d1 = new Dude("John");
var d2 = new Dude("John");

Console.WriteLine(d1 == d2);       // False

var d3 = d1;

Console.WriteLine(d1 == d3);       // True

namespace MyNamespace
{
    public class Dude
    {
        private string Name;
        public Dude(string n) { Name = n; }
    }
}
// The parameterless constructor constraint requires T to have a public parameterless constructor.
// If this constraint is defined, you can call new() on T:

using System.Text;

var builders = new StringBuilder [100];
Initialize (builders);
Console.WriteLine(builders[37]);

static void Initialize<T> (T[] array) where T : new()
{
    for (int i = 0; i < array.Length; i++)
        array [i] = new T();
}
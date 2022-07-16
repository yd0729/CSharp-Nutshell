var bob = ("Bob", 23);

(string name, int age) = bob;   // Deconstruct the bob tuple into
// separate variables (name and age).
Console.WriteLine (name);
Console.WriteLine (age);

var (name2, age2, sex) = GetBob();
Console.WriteLine (name2);        // Bob
Console.WriteLine (age2);         // 23
Console.WriteLine (sex);         // M

static (string, int, char) GetBob() => ( "Bob", 23, 'M');
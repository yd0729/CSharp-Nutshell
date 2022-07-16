var bob = ("Bob", 23);    // Allow compiler to infer the element types

Console.WriteLine (bob.Item1);   // Bob
Console.WriteLine (bob.Item2);   // 23

// Tuples are mutable value types:

var joe = bob;        // joe is a *copy* of job
joe.Item1 = "Joe";             // Change joe’s Item1 from Bob to Joe
Console.WriteLine (bob);       // (Bob, 23)
Console.WriteLine (joe);       // (Joe, 23)

// Unlike with anonymous types, you can specify a tuple type explicitly
(string,int) bob2  = ("Bob", 23);   // var is not compulsory with tuples!

Console.WriteLine(bob2.Item1);
Console.WriteLine(bob2.Item2);

var tuples = new[]
{
    ("B", 50),
    ("B", 40),
    ("A", 30),
    ("A", 20)
};

foreach (var tuple in tuples.OrderBy (x => x))
{
    Console.WriteLine($"{tuple.Item1} {tuple.Item2}");
}
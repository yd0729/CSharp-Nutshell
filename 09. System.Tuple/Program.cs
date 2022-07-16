// 这种 Tuple 是引用类型，但 ValueTuple 避免了内存分配，性能更好。
Tuple<string, int> t = Tuple.Create("Bob", 23);

Console.WriteLine(t.Item1);
Console.WriteLine(t.Item2);
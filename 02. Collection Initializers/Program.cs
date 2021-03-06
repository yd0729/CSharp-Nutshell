// You can instantiate and populate an enumerable object in a single step with collection initializers:

{
    List<int> list = new List<int> { 1, 2, 3 };

    Console.WriteLine(list);
}

// Equivalent to:
{
    List<int> list = new List<int>();
    list.Add(1);
    list.Add(2);
    list.Add(3);

    Console.WriteLine(list);
}
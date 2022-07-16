var tuple = (Name:"Bob", Age:23);

Console.WriteLine (tuple.Name);     // Bob
Console.WriteLine (tuple.Age);      // 23

var person = GetPerson();
Console.WriteLine (person.Name);    // Bob
Console.WriteLine (person.Age);     // 23

static (string Name, int Age) GetPerson() => ("Bob", 23);
var p1 = new Person1(null); // Null check is bypassed.

try
{
    var p2 = new Person2(null); // Null check succeeds (throws).
}
catch (ArgumentNullException ex)
{
    Console.WriteLine(ex);
}

// Primary constructors don't play well when you need property validation:
internal record Person1(string Name)
{
    private readonly string _name = Name; // Assigns to *FIELD*

    public string Name
    {
        get => _name;
        init => _name = value ?? throw new ArgumentNullException("Name");
    }
}

// The easiest solution is usually to write the constructor yourself:
internal record Person2
{
    private readonly string _name;

    public Person2(string name)
    {
        Name = name;
        // Assigns to *PROPERTY*
    }

    public string Name
    {
        get => _name;
        init => _name = value ?? throw new ArgumentNullException("Name");
    }
}
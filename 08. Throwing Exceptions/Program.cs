// Exceptions can be thrown either by the runtime or in user code:

try
{
    Display(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Caught the exception");
}

static void Display(string name)
{
    if (name == null)
    {
        throw new ArgumentNullException(nameof(name));
    }

    Console.WriteLine(name);
}
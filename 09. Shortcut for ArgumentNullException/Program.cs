// Exceptions can be thrown either by the runtime or in user code:

try
{
    Display(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine($"Caught the exception: {ex.Message}");
}

void Display(string name)
{
    ArgumentNullException.ThrowIfNull(name);
    Console.WriteLine(name);
}
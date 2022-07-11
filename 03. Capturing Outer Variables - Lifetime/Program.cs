// Captured variables have their lifetimes extended to that of the delegate:

Func<int> natural = Natural();
Console.WriteLine (natural());      // 0
Console.WriteLine (natural());      // 1

static Func<int> Natural()
{
    int seed = 0;
    return () => seed++;	  // Returns a closure
}
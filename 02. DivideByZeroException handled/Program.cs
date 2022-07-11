// We can catch the DivideByZeroException as follows:

try
{
    int y = Calc (0);
    Console.WriteLine (y);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine ("x cannot be zero");
}
Console.WriteLine ("program completed");

int Calc (int x) { return 10 / x; }
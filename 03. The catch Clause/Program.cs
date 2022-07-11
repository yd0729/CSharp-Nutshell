// You can handle multiple exception types with multiple catch clauses:

internal class Program
{
    private static void Main() { MainMain ("one"); }

    private static void MainMain (params string[] args)
    {
        try
        {
            byte b = byte.Parse(args[0]);
            Console.WriteLine(b);
        }
        catch (IndexOutOfRangeException) // no variable
        {
            Console.WriteLine("Please provide at least one argument");
        }
        catch (FormatException)
        {
            Console.WriteLine("That's not a number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("You've given me more than a byte!");
        }
        catch  // 捕获所有异常
        {
            
        }
    }
}
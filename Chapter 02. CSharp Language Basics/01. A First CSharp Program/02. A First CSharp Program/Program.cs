// Here's our first C# program - without using top-level statements.
// You'll see a lot of this if you're working with code written prior to C# 9.
// Notice that we've changed the Language in the dropdown above from 'C# Statements' to 'C# Program'.

class Program
{
    static void Main()
    {
        Console.WriteLine(FeetToInches(30)); // 360
        Console.WriteLine(FeetToInches(100)); // 1200
    }

    static int FeetToInches(int feet)
    {
        int inches = feet * 12;
        return inches;
    }
}
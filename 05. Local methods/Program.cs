class Program
{
    public static void Main()
    {
        WriteCubes();
    }

    static void WriteCubes()
    {
        Console.WriteLine(Cube(3));
        Console.WriteLine(Cube(4));
        Console.WriteLine(Cube(5));

        // local method
        int Cube(int value) => value * value * value;
    }
}
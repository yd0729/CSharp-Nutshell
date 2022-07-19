// Implicit and explicit conversions are overloadable operators:

var n = (Note)554.37; // explicit conversion
double x = n; // implicit conversion
Console.WriteLine(x);

public struct Note
{
    public int SemitonesFromA { get; }

    public Note(int semitonesFromA)
    {
        SemitonesFromA = semitonesFromA;
    }

    // Convert to hertz
    public static implicit operator double(Note x)
    {
        return 440 * Math.Pow(2, (double)x.SemitonesFromA / 12);
    }

    // Convert from hertz (accurate to the nearest semitone)
    public static explicit operator Note(double x)
    {
        return new((int)(0.5 + 12 * (Math.Log(x / 440) / Math.Log(2))));
    }
}
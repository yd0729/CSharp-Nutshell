// An operator is overloaded by declaring an operator function:

var b = new Note(2);
var cSharp = b + 2;
Console.WriteLine(cSharp.SemitonesFromA);


cSharp += 2;
Console.WriteLine(cSharp.SemitonesFromA);

public struct Note
{
    public int SemitonesFromA { get; }

    public Note(int semitonesFromA)
    {
        SemitonesFromA = semitonesFromA;
    }

    public static Note operator +(Note x, int semitones)
    {
        return new Note(x.SemitonesFromA + semitones);
    }

    // Or more tersely:
    // public static Note operator + (Note x, int semitones) => new Note (x.value + semitones);

    // See the last example in "Equality Comparison", Chapter 6 for an example of overloading the == operator
}
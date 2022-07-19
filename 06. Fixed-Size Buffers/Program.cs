// Memory can be allocated in a block within a struct using the fixed keyword:

new UnsafeClass("Christian Troy");

internal unsafe struct UnsafeUnicodeString
{
    public short Length;
    public fixed byte Buffer[30];
}

internal unsafe class UnsafeClass
{
    private readonly UnsafeUnicodeString uus;

    public UnsafeClass(string s)
    {
        uus.Length = (short)s.Length;
        for (var i = 0; i < s.Length; i++) uus.Buffer[i] = (byte)s[i];
    }
}
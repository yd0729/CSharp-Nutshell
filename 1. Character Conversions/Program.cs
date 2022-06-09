// An implicit conversion from a char to a numeric type works for the numeric types that can
// accommodate an unsigned short:

const ushort us = 'a';
const int i = 'z';

Console.WriteLine(us);
Console.WriteLine(i);

// For other numeric types, an explicit conversion is required

const short s = (short) 'a';

Console.WriteLine(s);
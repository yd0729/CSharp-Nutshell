// Character literals

{
    // C#’s char type represents a Unicode character and occupies two bytes.

    char c = 'A'; // Simple character

    // Escape sequences express characters that cannot be expressed or interpreted literally.
    // An escape sequence is a backslash followed by a character with a special meaning:

    char newLine = '\n';
    char backSlash = '\\';

    Console.WriteLine(backSlash.ToString() + newLine.ToString() + backSlash.ToString());
}

// Character conversions
{
    // An implicit conversion from a char to a numeric type works for the numeric types that can
    // accommodate an unsigned short:

    ushort us = 'a';
    int i = 'z';

    // For other numeric types, an explicit conversion is required

    short s = (short)'a';
}
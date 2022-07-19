IsJanetOrJohn("Janet");
IsVowel('e');
Between1And9(5);
IsLetter('!');

bool IsJanetOrJohn(string name)
{
    return name.ToUpper() is "JANET" or "JOHN";
}

bool IsVowel(char c)
{
    return c is 'a' or 'e' or 'i' or 'o' or 'u';
}

bool Between1And9(int n)
{
    return n is >= 1 and <= 9;
}

bool IsLetter(char c)
{
    return c is >= 'a' and <= 'z'
        or >= 'A' and <= 'Z';
}
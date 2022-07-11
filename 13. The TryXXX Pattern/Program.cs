﻿bool result;
TryToBoolean ("Bad", out result);
result = ToBoolean ("Bad");		// throws Exception

bool ToBoolean (string text)
{
    if (!TryToBoolean (text, out var returnValue))
        throw new FormatException ("Cannot parse to Boolean");
    return returnValue;
}

bool TryToBoolean (string text, out bool result)
{
    text = text.Trim().ToUpperInvariant();	
    if (text is "TRUE" or "YES" or "Y")
    {
        result = true;
        return true;
    }
    if (text is "FALSE" or "NO" or "N")
    {
        result = false;
        return true;
    }
    result = false;
    return false;
}
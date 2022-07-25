foreach (char c in "gfdx")
{
    Format (c.ToString());
}

void Format (string formatString)
{
    Console.WriteLine($"ToString (\"{formatString}\") : {ConsoleColor.Red.ToString (formatString)}");
}
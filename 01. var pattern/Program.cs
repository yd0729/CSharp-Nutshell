IsJanetOrJohn("Janet");
IsJanetOrJohn("john");

bool IsJanetOrJohn(string name)
{
    return name.ToUpper() is var upper && (upper == "JANET" || upper == "JOHN");
}
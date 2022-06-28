// Null-Conditional Operator
{
    System.Text.StringBuilder sb = null;
    string s = sb?.ToString();   // No error; s instead evaluates to null
    string s2 = sb?.ToString().ToUpper();   // s evaluates to null without error
}

// Null-Conditional Operator with nullable types
{
    System.Text.StringBuilder sb = null;
    int? length = sb?.ToString().Length;   // OK : int? can be null
    string s = sb?.ToString() ?? "nothing";   // s evaluates to "nothing"
}

// Prior to C# 7, throw was always a statement. Now it can also appear as an expression in
// expression-bodied functions:

Console.WriteLine(ProperCase("test"));
ProperCase(null); // throws an ArgumentException

string Foo() => throw new NotImplementedException();

// A throw expression can also appear in a ternary conditional expression:

string ProperCase(string value) =>
    value == null ? throw new ArgumentException("value") :
    value == "" ? "" :
    char.ToUpper(value[0]) + value.Substring(1);
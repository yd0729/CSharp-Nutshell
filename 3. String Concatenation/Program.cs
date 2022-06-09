// The + operator concatenates two strings:
const string s1 = "a" + "b";

Print(nameof(s1), s1);


// The right-hand operand may be a nonstring value, in which case ToString is called on that value:
var s2 = "a" + 5;   // a5 不能是 const

Print(nameof(s2), s2);

void Print(string name, object o)
{
    Console.WriteLine($"{name}: {o}");
}
using System.ComponentModel;
using System.Reflection;

Action<int> a =
    [Description("Method")] [return: Description("Return value")]
    ([Description("Parameter")] x) => Console.WriteLine(x);

foreach (var attribute in a.GetMethodInfo().GetCustomAttributes()) Console.Write($"{attribute} ");

Console.WriteLine();

foreach (var attribute in a.GetMethodInfo().GetParameters()[0].GetCustomAttributes()) Console.Write($"{attribute} ");

Console.WriteLine();

foreach (var attribute in a.GetMethodInfo().ReturnParameter.GetCustomAttributes()) Console.Write($"{attribute} ");
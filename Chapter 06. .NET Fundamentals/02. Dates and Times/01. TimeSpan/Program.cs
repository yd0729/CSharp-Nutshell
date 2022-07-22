// There are three ways to construct a TimeSpan:
//  • Through one of the constructors
//  • By calling one of the static From . . . methods
//  • By subtracting one DateTime from another

Console.WriteLine(new TimeSpan(2, 30, 0)); // 02:30:00
Console.WriteLine(TimeSpan.FromHours(2.5)); // 02:30:00
Console.WriteLine(TimeSpan.FromHours(-2.5)); // -02:30:00
Console.WriteLine(DateTime.MaxValue - DateTime.MinValue);

// TimeSpan overloads the < and > operators, as well as the + and - operators:

Console.WriteLine($"2.5 hours : {TimeSpan.FromHours(2) + TimeSpan.FromMinutes(30)}");

var nearlyTenDays = TimeSpan.FromDays(10) - TimeSpan.FromSeconds(1);
Console.WriteLine($"One second short of 10 days: {nearlyTenDays}");
Console.WriteLine(nearlyTenDays.TotalDays);
Console.WriteLine(nearlyTenDays.TotalMilliseconds);

// Time 也可以用来表示一天中的时间
var now = DateTime.Now.TimeOfDay;
Console.WriteLine(now);
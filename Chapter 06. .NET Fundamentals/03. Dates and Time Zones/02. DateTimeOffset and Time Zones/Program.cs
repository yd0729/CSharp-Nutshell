// Comparisons look only at the (UTC) DateTime; the Offset is used primarily for formatting.

DateTimeOffset local = DateTimeOffset.Now;
DateTimeOffset utc = local.ToUniversalTime();

Console.WriteLine(local.Offset); // -06:00:00 (in Central America)
Console.WriteLine(utc.Offset); // 00:00:00

Console.WriteLine(local == utc); // True ，虽然是不同的时区，但表示的是同一个时间

// To include the Offset in the comparison, you must use the EqualsExact method:

Console.WriteLine(local.EqualsExact(utc)); // False ，在比较时也比较时区是否相同
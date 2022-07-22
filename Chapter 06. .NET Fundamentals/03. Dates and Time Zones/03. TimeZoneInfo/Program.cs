// TimeZoneInfo.Local returns the current local time zone:

TimeZoneInfo zone = TimeZoneInfo.Local;
Console.WriteLine($"StandardName (local): {zone.StandardName}");
Console.WriteLine($"DaylightName (local): {zone.DaylightName}");

DateTime dt1 = new DateTime(2019, 1, 1);
DateTime dt2 = new DateTime(2019, 4, 5);
Console.WriteLine(zone.IsDaylightSavingTime(dt1));
Console.WriteLine(zone.IsDaylightSavingTime(dt2));
Console.WriteLine(dt1.Kind);
Console.WriteLine(dt2.Kind);
Console.WriteLine(zone.GetUtcOffset(dt1));  // 计算此时区中的时间与协调世界时 (UTC) 之间针对特定日期和时间的偏移量或差值（因为夏令时的存在，偏移量在不同的时间可能会不一样）。
Console.WriteLine(zone.GetUtcOffset(dt2));

// You can obtain a TimeZoneInfo for any of the world’s time zones by calling FindSystemTimeZoneById with the zone ID:
TimeZoneInfo wa = TimeZoneInfo.FindSystemTimeZoneById("W. Australia Standard Time");

Console.WriteLine(wa.Id); // W. Australia Standard Time
Console.WriteLine(wa.DisplayName); // (GMT+08:00) Perth
Console.WriteLine(wa.BaseUtcOffset); // 08:00:00
Console.WriteLine(wa.SupportsDaylightSavingTime); // True
Console.WriteLine();

// The following returns all world timezones:
foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
{
    Console.WriteLine(z.Id);
}
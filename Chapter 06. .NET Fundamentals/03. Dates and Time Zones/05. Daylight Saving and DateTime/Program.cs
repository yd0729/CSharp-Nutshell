// The IsDaylightSavingTime tells you whether a given local DateTime is subject to daylight saving.
Console.WriteLine (DateTime.Now.IsDaylightSavingTime());     // True or False
Console.WriteLine(DateTimeOffset.Now.LocalDateTime.IsDaylightSavingTime());

// UTC times always return false: UTC 时间没有夏令时的概念
Console.WriteLine (DateTime.UtcNow.IsDaylightSavingTime());  // Always False


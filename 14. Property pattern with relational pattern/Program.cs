Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

bool ShouldAllow(Uri uri)
{
    return uri switch
    {
        { Host: { Length: < 1000 }, Port: > 0 } => true,
        _ => false
    };
}
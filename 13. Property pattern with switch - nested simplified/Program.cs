Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

bool ShouldAllow(Uri uri)
{
    return uri switch
    {
        { Scheme.Length: 4, Port: 80 } => true, // Simplified syntax (from C# 10)
        _ => false
    };
}
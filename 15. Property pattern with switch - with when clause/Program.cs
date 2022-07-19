Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

bool ShouldAllow(Uri uri)
{
    return uri switch
    {
        { Scheme: "http" } when string.IsNullOrWhiteSpace(uri.Query) => true,
        _ => false
    };
}
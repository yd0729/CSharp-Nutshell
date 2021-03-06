Console.WriteLine(ShouldAllow(new Uri("http://www.linqpad.net")));
Console.WriteLine(ShouldAllow(new Uri("ftp://ftp.microsoft.com")));
Console.WriteLine(ShouldAllow(new Uri("tcp:foo.database.windows.net")));

bool ShouldAllow(object uri)
{
    return uri switch
    {
        Uri { Scheme: "http", Port: 80 } httpUri => httpUri.Host.Length < 1000,
        Uri { Scheme: "https", Port: 443 } => true,
        Uri { Scheme: "ftp", Port: 21 } => true,
        Uri { IsLoopback: true } => true,
        _ => false
    };
}
// Rethrowing lets you back out of handling an exception should circumstances turn out to be
// outside what you expected:

using System.Net;

string s = null;

try
{
    s = await new HttpClient().GetStringAsync("http://www.albahari.com/x");
}
catch (HttpRequestException ex)
{
    if (ex.StatusCode == HttpStatusCode.Forbidden)
        Console.WriteLine("Forbidden");
    else
    {
        throw; // Can’t handle other cases, so rethrow
        // 在这里 throw ex; 是错误的．
    }
}
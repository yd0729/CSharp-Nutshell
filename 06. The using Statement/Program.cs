// The using statement provides an elegant syntax for calling Dispose on
// an IDisposable object within a finally block:

File.WriteAllText("file.txt", "test");
ReadFile();

void ReadFile()
{
    using (StreamReader reader = File.OpenText("file.txt"))
    {
        if (reader.EndOfStream) return;
        Console.WriteLine(reader.ReadToEnd());
    }
}
// finally blocks are typically used for cleanup code:

File.WriteAllText("file.txt", "test");
ReadFile();

void ReadFile()
{
    StreamReader reader = null; // In System.IO namespace
    try
    {
        reader = File.OpenText("file.txt");
        if (reader.EndOfStream) return;
        Console.WriteLine(reader.ReadToEnd());
    }
    finally
    {
        if (reader != null) reader.Dispose();
    }
}
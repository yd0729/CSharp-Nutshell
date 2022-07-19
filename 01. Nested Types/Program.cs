// A nested type is declared within the scope of another type. For example:

class Program
{
    public class TopLevel
    {
        public class Nested
        {
        } // Nested class

        public enum Color
        {
            Red,
            Blue,
            Tan
        } // Nested enum
    }

    private static void Main()
    {
        TopLevel.Color color = TopLevel.Color.Red;
    }
}
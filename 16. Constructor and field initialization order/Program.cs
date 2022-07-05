class Program
{
    public static void Main(string[] args)
    {
        D d = new(1);
    }

    private static int order = 0;

    class B
    {
        protected int x = 1; // Executes 3rd

        public B(int x)
        {
            // Executes 4th
            System.Console.WriteLine($"x = {this.x}");
            this.x = x;
            System.Console.WriteLine($"x = {this.x}");
            System.Console.WriteLine($"B constructor execute, order = {++order}");
        }
    }

    class D : B
    {
        private int y = 1; // Executes 1st

        public D(int x) : base(x + 1) // x + 1 Executes 2nd
        {
            // Executes 5th
            System.Console.WriteLine($"x = {this.x}, y = {y}");
            System.Console.WriteLine($"D constructor execute, order = {++order}");
        }
    }
}
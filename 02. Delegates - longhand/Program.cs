Transformer t = new Transformer (Square);  // Create delegate instance
int result = t(3);                         // Invoke delegate
Console.WriteLine (result);                // 9

int Square (int x) => x * x;

delegate int Transformer (int x);          // Delegate type declaration
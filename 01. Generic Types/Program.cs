// A generic type declares type parameters—placeholder types to be filled in by the consumer
// of the generic type, which supplies the type arguments:

var stack = new Stack<int>();

stack.Push (5);
stack.Push (10);

int x = stack.Pop();        // x is 10
int y = stack.Pop();        // y is 5

Console.WriteLine(x);
Console.WriteLine(y);

public class Stack<T>
{
    int position;
    T[] data = new T [100];
    public void Push (T obj) => data [position++] = obj;
    public T Pop() => data [--position];  // 不是 generic method ，因为虽然有 T ，但 T 不是 Pop 引入的．
}
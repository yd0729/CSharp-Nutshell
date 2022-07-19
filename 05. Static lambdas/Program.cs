// 如果 lambda 不捕获变量，在运行时就不需要为捕获的变量分配内存．
// static 只是一种确认，不会影响实际生成的 IL ．

Func<int, int> multiplier = static n => n * 2;
multiplier(123);

Foo();


// static 同样可以用于 local method
void Foo()
{
    Multiply(123);
    static int Multiply(int x) => x * 2; // Local static method
}
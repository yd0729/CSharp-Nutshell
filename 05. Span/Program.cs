// you can use Span<T> to manage stack-allocated memory without using the unsafe keyword

Span<int> a = stackalloc int[10];
for (var i = 0; i < 10; i += 1) Console.WriteLine(a[i]);
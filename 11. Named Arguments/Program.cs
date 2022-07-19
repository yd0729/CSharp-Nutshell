﻿// Rather than identifying an argument by position, you can identify it by name:

Foo(x: 1, y: 2); // 1, 2
Foo(y: 2, x: 1); // 1, 2   (semantically same as above)

// You can mix named and positional arguments:
Foo(1, y: 2);

void Foo(int x, int y)
{
    Console.WriteLine(x + ", " + y);
}
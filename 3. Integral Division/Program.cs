// Integral division truncates remainders:

const int a = 2 / 3;      // 0

Console.WriteLine(a);

// Division by zero is an error:

var b = 0;
var c = 5 / b;      // throws DivisionByZeroException

// const 会编译失败
// const int d = 0;
// const int e = 5 / b;
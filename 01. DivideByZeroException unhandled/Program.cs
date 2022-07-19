// Because Calc is called with x==0, the runtime throws a DivideByZeroException: 

int y = Calc(0);
Console.WriteLine(y);

int Calc(int x)
{
    return 10 / x;
}
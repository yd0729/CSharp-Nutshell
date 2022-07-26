foreach (byte b in BitConverter.GetBytes(3.5))
{
    Console.Write ($"{b} ");                          // 0 0 0 0 0 0 12 64
}
Console.WriteLine();

var d  = 3.5M;
var bits = decimal.GetBits(d);
foreach (var b in bits)
{
    Console.Write($"{b} ");
}
Console.WriteLine();

var dt = DateTime.Now;
Console.WriteLine(dt);
var dtb = dt.ToBinary();
dt = DateTime.FromBinary(dtb);
Console.WriteLine(dt);
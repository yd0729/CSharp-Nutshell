// Partial types allow a type definition to be split—typically across multiple files:

new PaymentForm { X = 3, Y = 4 }

partial class PaymentForm { public int X; }
partial class PaymentForm { public int Y; }
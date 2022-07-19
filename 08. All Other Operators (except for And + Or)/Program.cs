// These operators return null when any of the operands are null. This pattern should be familiar to SQL users:

int? x = 5;
int? y = null;
{
    int? c = x + y;
}
// Translation:
{
    int? c = (x.HasValue && y.HasValue)
        ? (int?)(x.Value + y.Value)
        : null;
}
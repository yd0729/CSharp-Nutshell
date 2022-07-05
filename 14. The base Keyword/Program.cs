class Program
{
    public static void Main(string[] args)
    {
        
    }
}

public class House : Asset
{
    public override decimal Liability => base.Liability + Mortgage;
}

public class Asset
{
    public decimal Mortgage;
    public virtual decimal Liability => 0;		// Virtual
}
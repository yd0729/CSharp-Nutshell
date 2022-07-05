// From C# 9, we can override a method such that it returns a more derived (subclased) type:

House mansion1 = new House { Name = "McMansion", Mortgage = 250000 };
House mansion2 = mansion1.Clone();

public class Asset
{
    public string Name;
    public virtual Asset Clone() => new Asset { Name = Name };
}

public class House : Asset
{
    public decimal Mortgage;
	
    // We can return House when overriding:
    public override House Clone() => new House { Name = Name, Mortgage = Mortgage };
}
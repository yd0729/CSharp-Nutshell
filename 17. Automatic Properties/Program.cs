// Here's the preceding example rewritten with two automatic properties:

var stock = new Stock { CurrentPrice = 50, SharesOwned = 100 };

public class Stock
{
    public decimal CurrentPrice { get; set; } // Automatic property
    public decimal SharesOwned { get; set; } // Automatic property

    public decimal Worth
    {
        get { return CurrentPrice * SharesOwned; }
    }
}
// There's a standard pattern for writing events. The pattern provides
// consistency across both Framework and user code.

var stock = new Stock("THPW")
{
    Price = 27.10M
};
// Register with the PriceChanged event
stock.PriceChanged += CheckVariation;
stock.Price = 31.59M;

void CheckVariation(object? sender, PriceChangedEventArgs e) // sender 是广播消息的那个实例
{
    if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
    {
        Console.WriteLine("Alert, 10% stock price increase!");
    }
}

public class PriceChangedEventArgs : EventArgs
{
    public readonly decimal LastPrice;
    public readonly decimal NewPrice;

    public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
    {
        LastPrice = lastPrice;
        NewPrice = newPrice;
    }
}

public class Stock
{
    string symbol;
    decimal price;

    public Stock(string symbol)
    {
        this.symbol = symbol;
    }

    public event EventHandler<PriceChangedEventArgs>? PriceChanged;

    protected virtual void OnPriceChanged(PriceChangedEventArgs e)
    {
        PriceChanged?.Invoke(this, e); // ?. thread safe
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (price == value) return;
            decimal oldPrice = price;
            price = value;
            OnPriceChanged(new(oldPrice, price));
        }
    }
}
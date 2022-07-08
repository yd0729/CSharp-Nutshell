// The predefined nongeneric EventHandler delegate can be used when an event doesn't
// carry extra information:

var stock = new Stock("THPW")
{
    Price = 27.10M
};
// Register with the PriceChanged event
stock.PriceChanged += PrintPrice;
stock.Price = 31.59M;

void PrintPrice(object? sender, EventArgs e)
{
    if (sender != null)
    {
        Console.WriteLine("New price = " + ((Stock)sender).Price);
    }
}

public class Stock
{
    private decimal _price;

    public Stock(string symbol)
    {
    }

    public event EventHandler? PriceChanged;

    protected virtual void OnPriceChanged(EventArgs e)
    {
        PriceChanged?.Invoke(this, e);
    }

    public decimal Price
    {
        get => _price;
        set
        {
            if (_price == value) return;
            _price = value;
            OnPriceChanged(EventArgs.Empty);
        }
    }
}
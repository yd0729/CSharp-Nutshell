// We can take over the default event implementation by writing our own accessors:

var stock = new Stock
{
    Price = 27.10M
};

// Register with the PriceChanged event
stock.PriceChanged += PrintNewPrice;
stock.Price = 31.59M;

void PrintNewPrice(object? sender, EventArgs e)
{
    if (sender != null)
    {
        Console.WriteLine("New price = " + ((Stock)sender).Price);
    }
}

public class Stock
{
    private decimal _price;

    private EventHandler? _priceChanged; // Declare a private delegate

    public event EventHandler? PriceChanged
    {
        add => _priceChanged += value; // Explicit accessor
        remove => _priceChanged -= value; // Explicit accessor
    }

    protected virtual void OnPriceChanged(EventArgs e)
    {
        _priceChanged?.Invoke(this, e);
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
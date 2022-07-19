// Properties look like fields from the outside but internally, they contain logic, like methods:

var stock = new Stock();
stock.CurrentPrice = 123.45M;

var stock2 = new Stock { CurrentPrice = 83.12M };

public class Stock
{
    decimal currentPrice; // The private "backing" field

    public decimal CurrentPrice // The public property
    {
        get { return currentPrice; }
        set { currentPrice = value; }
    }
}
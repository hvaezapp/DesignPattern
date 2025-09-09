namespace ObserverExample2;

public class Investor(string name) : IInvestor
{
    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {name} of {stock.Symbol} change to {stock.Price:c}");
    }
}
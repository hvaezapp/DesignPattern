namespace ObserverExample1;

public class SMSSubscriber
{
    private string _phoneNumber;

    public SMSSubscriber(string phoneNumber, OnlineStore store)
    {
        _phoneNumber = phoneNumber;
        store.DiscountAnnounced += ReceiveDiscount;
    }

    private void ReceiveDiscount(Discount discount)
    {
        // sending sms
        Console.WriteLine($"SMS to {_phoneNumber}: {discount.DiscountPercentage}% discount on {discount.ProductName}");
    }

    public void Unsubscribe(OnlineStore store)
    {
        store.DiscountAnnounced -= ReceiveDiscount;
    }
}

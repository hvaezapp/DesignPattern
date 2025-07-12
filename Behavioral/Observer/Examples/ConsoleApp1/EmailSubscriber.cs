namespace ObserverExample1
{
    public class EmailSubscriber
    {
        private string _email;

        public EmailSubscriber(string email, OnlineStore store)
        {
            _email = email;
            store.DiscountAnnounced += ReceiveDiscount;
        }

        private void ReceiveDiscount(Discount discount)
        {
            // sending mail
            Console.WriteLine($"Email to {_email}: {discount.DiscountPercentage}% discount on {discount.ProductName}");
        }

        public void Unsubscribe(OnlineStore store)
        {
            store.DiscountAnnounced -= ReceiveDiscount;
        }
    }
}

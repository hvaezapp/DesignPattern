namespace ObserverExample1
{
    public class OnlineStore
    {
        public delegate void DiscountAnnouncedEventHandler(Discount discount);
        public event DiscountAnnouncedEventHandler DiscountAnnounced;


        public void AnnounceDiscount(string productName, int discountPercentage)
        {
            var discount = new Discount(productName, discountPercentage);
            Console.WriteLine($"Store: New discount announced for {discount.ProductName} ({discount.DiscountPercentage}%)!");
            DiscountAnnounced?.Invoke(discount);
        }

    }
}

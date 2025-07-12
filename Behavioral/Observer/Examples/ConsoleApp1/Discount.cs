namespace ObserverExample1
{
    public class Discount
    {
        public string ProductName { get; }
        public int DiscountPercentage { get; }

        public Discount(string productName, int discountPercentage)
        {
            ProductName = productName;
            DiscountPercentage = discountPercentage;
        }
    }
}

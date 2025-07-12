
namespace FactoryExample2
{
    public class Paypal : IPayment
    {
        public void Pay(decimal amount)
        {
            // TODO
            Console.WriteLine("Paypal operating ... ");
        }
    }

}
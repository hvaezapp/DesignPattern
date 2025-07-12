
namespace FactoryExample2
{
    public class PaymentFactory
    {
        public static IPayment Create(PaymentMethod type)
        {
            return type switch
            {
                PaymentMethod.Strip => new Strip(),
                PaymentMethod.Paypal => new Paypal(),
                _ => throw new Exception("payment method doesn't exist !"),
            };
        }

        #region 
        //public static IPayment Create(string type)
        //{
        //    return type switch
        //    {
        //        "strip" => new Strip(),
        //        "paypal" => new Paypal(),
        //        _ => throw new Exception("payment method doesn't exist !"),
        //    };
        //}
        #endregion
    }


}
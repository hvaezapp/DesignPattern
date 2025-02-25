
using System.ComponentModel.DataAnnotations;

var strip = PaymentFactory.Create(PaymentMethod.Strip);
strip.Pay(1000);

var paypal = PaymentFactory.Create(PaymentMethod.Paypal);
paypal.Pay(2000);

Console.ReadLine();

//..............................

public interface IPayment
{
    void Pay(decimal amount);
}


public class Strip : IPayment
{
    public void Pay(decimal amount)
    {

        // TODO
        Console.WriteLine("Strip operating ... ");
    }
}

public class Paypal : IPayment
{
    public void Pay(decimal amount)
    {
        // TODO
        Console.WriteLine("Paypal operating ... ");
    }
}


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


public enum PaymentMethod
{
    [Display(Name = "Strip Payment Method")]
    Strip = 1,
    [Display(Name = "Paypal Payment Method")]
    Paypal
}
using System.ComponentModel.DataAnnotations;
namespace FactoryExample2;

public enum PaymentMethod
{
    [Display(Name = "Strip Payment Method")]
    Strip = 1,
    [Display(Name = "Paypal Payment Method")]
    Paypal
}

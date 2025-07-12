using FactoryExample2;

var strip = PaymentFactory.Create(PaymentMethod.Strip);
strip.Pay(1000);

var paypal = PaymentFactory.Create(PaymentMethod.Paypal);
paypal.Pay(2000);

Console.ReadLine();

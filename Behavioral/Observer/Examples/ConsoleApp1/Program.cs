
using ObserverExample1;

var store = new OnlineStore();

// Create Observers
var emailSubscriber = new EmailSubscriber("hassan.vaezzadeh1@gmail.com", store);
var smsSubscriber = new SMSSubscriber("+989011999639", store);

Console.WriteLine("First discount announcement:");
store.AnnounceDiscount("Gaming Laptop", 30);

Console.WriteLine("\nSecond discount announcement:");
store.AnnounceDiscount("Wireless Headphones", 60);

Console.WriteLine("\nEmail hassan.vaezzadeh1@gmail.com unsubscribed.");
emailSubscriber.Unsubscribe(store);

Console.WriteLine("\nThird discount announcement:");
store.AnnounceDiscount("Samsung Galaxy Smartphone", 45);
Console.ReadLine();
using ObserverExample2;

var ibm = new IBM("IBM", 250);

ibm.Attach(new Investor("Network"));
ibm.Attach(new Investor("Personal Computer"));
ibm.Attach(new Investor("Personal test"));

ibm.Price = 250.55;
ibm.Price = 150;
ibm.Price = 177.88;
ibm.Price = 250;

Console.ReadLine();
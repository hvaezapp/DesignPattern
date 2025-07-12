using FactoryExample1;

List<Employee> employees =
[
    EmployeeFactory.Create("Hassan Vaezzadeh", "Developer"),
    EmployeeFactory.Create("Hosein Rasoli", "Developer"),
    EmployeeFactory.Create("Ali Moradi", "Tester"),
    EmployeeFactory.Create("Mostafa Jamshidi", "QA")

];

employees.ForEach(e => Console.WriteLine(e.ToString()));
Console.ReadLine();



List<Employee> employees = new List<Employee>
{
    EmployeeFactory.Create("Hassan Vaezzadeh", "Developer"),
    EmployeeFactory.Create("Hosein Rasoli", "Developer"),
    EmployeeFactory.Create("Ali Moradi", "Tester"),
    EmployeeFactory.Create("Mostafa Jamshidi", "QA")

};

employees.ForEach(e => Console.WriteLine(e.ToString()));
Console.ReadLine();

//.......................

public class Employee
{
    private readonly string _name;
    private readonly string _type;
    public Employee(string name, string type)
    {
        _name = name;
        _type = type;
    }

    public override string ToString()
    {
        return $"name : {_name} , type : {_type}";
    }
}

public class Developer : Employee
{
    public Developer(string name, string type) : base(name, type)
    {

    }
}

public class Tester : Employee
{
    public Tester(string name, string type) : base(name, type)
    {

    }
}

public static class EmployeeFactory
{
    public static Employee Create(string name, string type)
    {
        return type switch
        {
            "Developer" => new Developer(name, type),
            "Tester" => new Tester(name, type),
            _ => new Employee(name, type),
        };

    }

}



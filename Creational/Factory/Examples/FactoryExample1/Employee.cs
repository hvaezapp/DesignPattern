namespace FactoryExample1;

public class Employee(string name, string type)
{
    private readonly string _name = name;
    private readonly string _type = type;

    public override string ToString()
    {
        return $"name : {_name} , type : {_type}";
    }
}



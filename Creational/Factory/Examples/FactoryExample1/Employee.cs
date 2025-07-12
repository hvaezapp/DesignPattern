namespace FactoryExample1
{
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
}



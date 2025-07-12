namespace FactoryExample1
{
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

}



namespace Domain.CalculationSalary
{
    public enum Role
    {
        Developer,
        Dba,
        Tester
    }

    public class Employee
    {
        public Employee(string name, double salary, Role role)
        {
            Name = name;
            Salary = salary;
            Role = role;
        }

        public string Name { get; private set; }
        public double Salary { get; private set; }
        public Role Role { get; private set; }
    }
}

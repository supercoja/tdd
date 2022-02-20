using Domain.CalculationSalary;
using Xunit;

namespace Domain.Tests
{
    public class CalculateSalaryTest
    {
        [Fact]
        public void DeveloperMustHave20Discount()
        {
            Employee employee = new Employee("Joey",4500,Role.Developer);
            var calculateSalary = new CalculateSalary();
            var resultSalary = calculateSalary.Calculate(employee);

            Assert.Equal(resultSalary,employee.Salary * .8);
        }

        [Fact]
        public void DeveloperMustHave10Discount()
        {
            Employee employee = new Employee("Joey", 2510, Role.Developer);
            var calculateSalary = new CalculateSalary();
            var resultSalary = calculateSalary.Calculate(employee);

            Assert.Equal(resultSalary, employee.Salary * .9);
        }

        [Fact]
        public void DBAAndTesterMustHave15Discount()
        {
            Employee employee = new Employee("Joey Montana DBA - 3500", 3400, Role.Dba);
            var calculateSalary = new CalculateSalary();
            var resultSalary = calculateSalary.Calculate(employee);

            Assert.Equal(resultSalary, employee.Salary * .85);
        }

        [Fact]
        public void DBAAndTesterMustHave25Discount()
        {
            Employee employee = new Employee("Joey Montana DBA - 1500", 1500, Role.Dba);
            var calculateSalary = new CalculateSalary();
            var resultSalary = calculateSalary.Calculate(employee);

            Assert.Equal(resultSalary, employee.Salary * .75);
        }
    }
}

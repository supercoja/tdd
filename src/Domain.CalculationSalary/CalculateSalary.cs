using System;
namespace Domain.CalculationSalary
{
    public class CalculateSalary
    {
        public double Calculate(Employee employee)
        {
            var salary = employee.Salary;
            if (employee.Role == Role.Developer)
                return TenOrTwentyPercentDiscount(employee);
            if (employee.Role == Role.Dba)
                return FifteenOrTwentyPercentdiscount(employee);

            return salary;
        }

        private double FifteenOrTwentyPercentdiscount(Employee employee)
        {
            if (employee.Salary > 2500)
                return employee.Salary * .85;

            return employee.Salary * .75;
        }

        private double TenOrTwentyPercentDiscount(Employee employee)
        {
            if (employee.Salary > 3000)
                return employee.Salary * .8;

            return employee.Salary * .9;
        }

    }
}

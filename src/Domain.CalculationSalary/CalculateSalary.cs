using System;
namespace Domain.CalculationSalary
{
    public class CalculateSalary
    {
        public static double Calculate(Employee employee)
        {
            var salary = employee.Salary;
            if (employee.Role == Role.Developer)
                if (salary > 3000)
                    salary = salary * .8;
                else
                    salary = salary * .9;
            if (employee.Role == Role.Dba)
                if (salary > 2500)
                    salary = salary * .75;
                else
                    salary = salary * .85;

            return salary;
        }
    }
}

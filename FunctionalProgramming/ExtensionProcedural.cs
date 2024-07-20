using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public class ExtensionProcedural
    {
        public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(string value)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if(employee.FirstName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesWithFirstNameEndsWith(string value)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.FirstName.ToLowerInvariant().EndsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesWithLastNameStartsWith(string value)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.LastName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesWithLastNameEndsWith(string value)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.LastName.ToLowerInvariant().StartsWith(value.ToLowerInvariant()))
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesByYearHired(int yearHired)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.HireDate.Year == yearHired)
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesByGender(string gender)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.Gender.ToLower() == gender.ToLower())
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesByPensionPlanValue(bool pensionPlan)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.HasPensionPlan == pensionPlan)
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesWithSalaryEqualTo(decimal salary)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary == salary)
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesWithSalaryGreaterThan(decimal value)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary > value)
                {
                    yield return employee;
                }
            }
        }
        public static IEnumerable<Employee> GetEmployeesWithSalaryLessThan(decimal value)
        {
            var employees = Repository.GetEmployees();
            foreach (var employee in employees)
            {
                if (employee.Salary < value)
                {
                    yield return employee;
                }
            }
        }
        public static void Print<T>(IEnumerable<T> source, string title)
        {
            if (source == null)
                return;
            Console.WriteLine();
            Console.WriteLine("┌───────────────────────────────────────────────────────┐");
            Console.WriteLine($"│   {title.PadRight(52, ' ')}│");
            Console.WriteLine("└───────────────────────────────────────────────────────┘");
            Console.WriteLine();
            foreach (var item in source)
                Console.WriteLine(item);
        }
    }
}

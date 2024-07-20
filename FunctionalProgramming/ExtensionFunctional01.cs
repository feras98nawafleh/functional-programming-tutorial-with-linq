using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class ExtensionFunctional01
    {
        // other way for method signature
        // public static IEnumerable<Employee> GetEmployeesWithFirstNameStartsWith(IEnumerable<Employee> employees, Func<Employee, bool> predicate)

        public static IEnumerable<Employee> Filter(IEnumerable<Employee> employees, Predicate<Employee> predicate)
        {
            foreach (var employee in employees)
            {
                if (predicate(employee))
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

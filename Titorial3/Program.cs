using FunctionalProgramming;
using System.Collections;
namespace Tutorial3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.GetEmployees();

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }; // generic types

            var collection = new ArrayList { 1, true, "hello world", DateTime.Now }; // non-generic types

            var evenNumbersUsingExtensionWhere = numbers.Where(n => n %  2 == 0); // construction (lazy loading)

            var evenNumbersUsingEnumerableWhere = Enumerable.Where(numbers, n => n % 2 == 0);

            var evenNumbersUsingQuerySyntax = 
                from n in numbers
                where n % 2 == 0
                select n;

            numbers.Add(10);
            numbers.Add(12);
            numbers.Remove(4);

            evenNumbersUsingExtensionWhere.Print("evenNumbersUsingExtensionWhere");
            evenNumbersUsingEnumerableWhere.Print("evenNumbersUsingEnumerableWhere");
            evenNumbersUsingQuerySyntax.Print("evenNumbersUsingQuerySyntax");
        }
    }
}

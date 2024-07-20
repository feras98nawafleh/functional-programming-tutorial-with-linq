namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProceduralWay();
            RunFunctionalWay();
            RunFunctionalWithExtension();
        }

        public static void RunProceduralWay()
        {
            // Procedural Way
            var q1 = ExtensionProcedural.GetEmployeesWithFirstNameStartsWith("f");
            ExtensionProcedural.Print(q1, "Employees with First Name Starts With F");

            var q2 = ExtensionProcedural.GetEmployeesWithFirstNameEndsWith("s");
            ExtensionProcedural.Print(q2, "Employees with Last Name Ends With S");

            var q3 = ExtensionProcedural.GetEmployeesByGender("Male");
            ExtensionProcedural.Print(q3, "Male Employees");

            var q4 = ExtensionProcedural.GetEmployeesByPensionPlanValue(false);
            ExtensionProcedural.Print(q4, "Employees with Pension Plan Value set to False");
        }
    
        public static void RunFunctionalWay()
        {
            // Functional way

            var employees = Repository.GetEmployees();

            // another way of passing the predicate:
            Predicate<Employee> predicate = e => e.LastName.ToLowerInvariant().EndsWith("S");
            var q0 = ExtensionFunctional01.Filter(employees, predicate);
            ExtensionFunctional01.Print(q0, "LastName.EndsWith(\"s\")");

            var q1 = ExtensionFunctional01.Filter(employees, e => e.FirstName.ToLower().StartsWith("f"));
            ExtensionFunctional01.Print(q1, "FirstName.StartsWith(\"f\")");


            var q2 = ExtensionFunctional01.Filter(employees, e => e.Salary == 10000);
            ExtensionFunctional01.Print(q2, "Salary == 10000");

            var q3 = ExtensionFunctional01.Filter(employees, e => e.Salary < 10000);
            ExtensionFunctional01.Print(q3, "Salary < 10000");

            var q4 = ExtensionFunctional01.Filter(employees, e => e.Salary >= 350000 && e.Gender.ToLowerInvariant() == "female");
            ExtensionFunctional01.Print(q4, "Salary > 300000 && Gender == \"female\"");
        }

        public static void RunFunctionalWithExtension()
        {
            var employees = Repository.GetEmployees();
            var q1 = employees.Filter(e => e.Gender.ToLowerInvariant() == "male");
            q1.Print("Male Employees");
        }

    }
}

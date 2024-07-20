namespace FunctionalProgramming
{
    internal class Program
    {
        static void Main(string[] args)
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
    }
}

using Tutorial4.Shared;

namespace Tutorial4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample1();
            SelectMany();
            Select();
            Zipping();
            LoadLength();
        }

        private static void RunExample1()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> words = new() { "I", "Love", ".Net" };

            var resultArray = numbersArray.Where(n => n > 5).Select(n => n * n);
            var result = words.Select(w => w.ToUpper());

            resultArray.Print("numbers");
            result.Print("words");
        }

        public static void Select()
        {
            var employees = Repository.GetEmployees();

            var result = 
                employees
                .Select(e =>
                    new EmployeeDTO
                    {
                        Name = e.FullName,
                        TotalSkills = e.Skills.Count()
                    }
                );
            result.Print("list");
        }

        public static void SelectMany()
        {
            var employees = Repository.GetEmployees();

            var query1 =
                employees
                .SelectMany(employee => employee.Skills, (employee, skill) => new { employee.FirstName, skill })
                .Where(e => e.skill.Count() > 0 && e.FirstName.ToLower().StartsWith("f"))
                .Select(emp => 
                    new { employeeName = emp.FirstName, Skill = emp.skill }
                );

            query1.Print("skills");
        }

        public static void Zipping()
        {

            // stops until one of the 2 arrays finishes if they're not the same length
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorHex = { "#FF000", "#00FF00", "#0000FF" };

            var colors = colorName.Zip(colorHex, (name, hex) => $"{name} {hex}");

            foreach (var item in colors)
            {
                Console.WriteLine($"{item}");
            }
        }

        public static void LoadLength()
        {
            var employees = Repository.GetEmployees().ToArray();

            var firstThree = employees[..3];
            var lastThree = employees[^3..];

            var teams = firstThree.Zip(lastThree, (first, last) => $"{first.FullName} with {last.FullName}");

            var limit = employees.Take(3).ToArray();

            teams.Print("zipped");
            limit.Print("limited");
        }
    }
}

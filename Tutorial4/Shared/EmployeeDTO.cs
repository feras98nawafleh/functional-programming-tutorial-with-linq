using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial4.Shared
{
    public class EmployeeDTO
    {
        public string? Name { get; set; }
        public int TotalSkills{ get; set; }

        public override string ToString()
        {
            return $"Name: {Name} with Total Skills {TotalSkills}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Employee:User
    {
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
    }
}

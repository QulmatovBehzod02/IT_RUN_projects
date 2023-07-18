using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.Repositories.Abstractions
{
    internal interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
        void Update(int id,Employee employee);
        void Delete(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Repositories.Abstractions;

namespace task.Repositories
{
    internal class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees=new();
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(int id)
        {
            Employee employeeForDelete = _employees.FirstOrDefault(x => x.Id == id);
            _employees.Remove(employeeForDelete);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public void Update(int id, Employee employee)
        {
            Employee employeeForUpdate = _employees.FirstOrDefault(x => x.Id == id);
            _employees.Add(employeeForUpdate);
        }
    }
}

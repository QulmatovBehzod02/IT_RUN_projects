using Applicatoin.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        List<Employee> _employees=new();
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public void RemoveEmployee(Employee employee)
        {
            _employees.Remove(employee);
        }

        public void UpdateEmployee(int id, Employee employee)
        {
            var index = _employees.FindIndex(s => s.Id == id);
            _employees[index]=employee;
        }
    }
}

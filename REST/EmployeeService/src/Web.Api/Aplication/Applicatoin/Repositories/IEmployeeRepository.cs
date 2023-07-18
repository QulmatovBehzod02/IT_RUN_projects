using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Applicatoin.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee>GetAll();
        void AddEmployee(Employee employee);
        void RemoveEmployee(Employee employee);
        void UpdateEmployee(int id,  Employee employee);
    }
}

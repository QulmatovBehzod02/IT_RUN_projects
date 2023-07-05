using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.Servises.Abstravtions
{
    internal interface IEmployeeService
    {
        void Create(string name, string userName, string password, string address, string email, string department, decimal salary, string position);
        void Update(int id, Employee employee);
        void Delete(int id);
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        Employee GetByDepartment(string department); 
    }
}

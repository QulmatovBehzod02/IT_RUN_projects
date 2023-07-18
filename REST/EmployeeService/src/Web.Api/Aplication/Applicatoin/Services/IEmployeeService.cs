using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
namespace Applicatoin.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        IEnumerable<Employee>GetByDepartment(string departmentName);
        void Create(int id,string name, decimal salary, string email, string username, string password, string position, string department);
        void Update(int id, string name, decimal salary, string email, string username, string password, string position, string department);
        void Delete(int id);
    }
}

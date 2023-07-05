using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Abstravtions.Services;
using task.Repositories.Abstractions;
using task.Servises.Abstravtions;

namespace task.Servises
{
    internal class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        IEmailSenderService _emailSenderService;

        public EmployeeService(IEmployeeRepository employeeRepository, IEmailSenderService emailSenderService) 
        {
            _employeeRepository = employeeRepository;
            _emailSenderService= emailSenderService;
        }

        public void Create(string name, string userName, string password, string address, string email, string department, decimal salary, string position)
        {
            Employee employee = new Employee();
            employee.Name = name;
            employee.UserName = userName;
            employee.Password = password;
            employee.Address = address;
            employee.Email = email;
            employee.Department = department;
            employee.Salary = salary;
            employee.Position = position;
            _employeeRepository.Add(employee);
            _emailSenderService.SendEmail(employee);
        }

        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees=_employeeRepository.GetAll();
            return employees;
        }

        public Employee GetByDepartment(string department)
        {
            var employeeDepartment = GetAll();
            return employeeDepartment.FirstOrDefault(x => x.Department == department);
        }

        public Employee GetById(int id)
        {
            var employee=GetAll();
            return employee.FirstOrDefault(s => s.Id == id);
        }

        public void Update(int id, Employee employee)
        {
            var employees = GetAll();
            var employeeForUpdate=employees.FirstOrDefault(s => s.Id == id);
            _employeeRepository.Update(id, employee);
        }
    }
}

using Applicatoin.Repositories;
using Applicatoin.Services;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        IEmailSenderService _emailSenderService;
        public EmployeeService(IEmployeeRepository employeeRepository, IEmailSenderService emailSenderService) 
        {
            _employeeRepository = employeeRepository;
            _emailSenderService = emailSenderService;
        }
        public void Create(int id,string name, decimal salary, string email, string username, string password, string position, string department)
        {
            var newEmployee = new Employee
            {
                Id = id,
                Name = name,
                Salary = salary,
                Email = email,
                UserName = username,
                Password = password,
                Position = position,
                Department = department
            };
            _employeeRepository.AddEmployee(newEmployee);
            _emailSenderService.SendEmail(email,"Wellcome");
        }

        public void Delete(int id)
        {
          
            var employee = _employeeRepository.GetAll().FirstOrDefault(s=>s.Id==id);
            if (employee!=null)
            {
                _employeeRepository.RemoveEmployee(employee);
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public IEnumerable<Employee> GetByDepartment(string departmentName)
        {
           return _employeeRepository.GetAll().Where(s => s.Department == departmentName);
            
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.GetAll().SingleOrDefault(s => s.Id==id);
        }

        public void Update(int id, string name, decimal salary, string email, string username, string password, string position, string department)
        {
            var employee = new Employee
            {
                Id = id,
                Name = name,
                Salary = salary,
                Email = email,
                UserName = username,
                Password = password,
                Position = position,
                Department = department
            };
            _employeeRepository.UpdateEmployee(id, employee);
        }
    }
}

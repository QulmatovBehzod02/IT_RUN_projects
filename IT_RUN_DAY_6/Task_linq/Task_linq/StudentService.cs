
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_linq
{
    public class StudentService
    {
        private List<Student> students;

        public StudentService()
        {
            students = new List<Student>();
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public void AddStudent(uint id, string firstName, string lastName, DateTime dateOfBirth)
        {
            Student student = new Student { Id = id, FirstName = firstName, LastName = lastName, DateOfBirth = dateOfBirth };
            students.Add(student);
        }
    }
}

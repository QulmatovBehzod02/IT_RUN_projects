
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

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task.Abstravtions.Services;

namespace task.Servises
{
    internal class EmailSenderService:IEmailSenderService
    {
        public void  SendEmail(Employee employee)
        {
            Console.WriteLine($"Hello {employee.Name}, congratulations, you are now our employee ");
        }
    }
}

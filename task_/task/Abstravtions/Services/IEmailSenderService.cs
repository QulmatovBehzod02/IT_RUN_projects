using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task.Abstravtions.Services
{
    internal interface IEmailSenderService
    {
        void SendEmail(Employee employee);
    }
}

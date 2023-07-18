using Applicatoin.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    internal class EmailSenderService : IEmailSenderService
    {
        public void SendEmail(string email, string text)
        {
            Console.WriteLine($"{text} is send to {email}");
        }
    }
}

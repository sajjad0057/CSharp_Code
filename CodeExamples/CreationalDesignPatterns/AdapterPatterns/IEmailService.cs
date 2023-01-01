using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AdapterPatterns
{
    public interface IEmailService
    {
        void Send(string email, string receiverName, string receiverEmail, string subject, string body);
    }
}

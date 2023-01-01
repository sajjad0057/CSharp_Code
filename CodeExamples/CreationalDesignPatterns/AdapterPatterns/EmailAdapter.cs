using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Adapter pattern works as a bridge between two incompatible interfaces.
This type of design pattern comes under structural pattern as this pattern 
combines the capability of two independent interfaces. 
*/

namespace CreationalDesignPatterns.AdapterPatterns
{

    /// <summary>
    /// Let's it is a class from 3rd perty Library - 
    /// </summary>
    public class EmailAdapter : IEmailService
    {
        public void Send(string email, string receiverName, string receiverEmail, string subject, string body)
        {
            EmailSender.SendEmail(receiverEmail, receiverName, body, subject, email);
        }
    }
}

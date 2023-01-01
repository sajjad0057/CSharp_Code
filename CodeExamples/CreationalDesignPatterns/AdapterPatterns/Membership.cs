using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.AdapterPatterns
{
    public class Membership
    {
        private readonly IEmailService _emailService;

        public Membership(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void CreateAccount(string email, string name, string password) 
        {
            //// Code for creating account 
            
            //// code for sending email
            
            _emailService.Send("info@sajjad.com", name, email,
                "welcome", "your A/C is ready !");
        }
    }
}

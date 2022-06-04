using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class Membership
    {
        /*
         According to SRP , A Class Can contain just Same responsible related code ... 
         */
        public void Singup(string username, string email, string password)
        {
            // Implimentation 1, check username / email is exists or not .
            // 2. Create a new user with username and password , email - > Data Operations 
            /* By the Condition of SRP , this class cannot contain  database related code or send confirmation email code . 
             * coz it is not related responsibility of member class 
            */
        }

        public void Login(string username , string password)
        {
            // implimentation 
        }
    }
}

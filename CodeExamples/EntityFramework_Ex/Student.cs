using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex
{
    public class Student    // here Student Class is called Entity , By this class In Entity Framework will make a table in database .
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }
        public string Address { get; set; } 
        public DateTime DateOfBirth { get; set; }
       
    }
}
 
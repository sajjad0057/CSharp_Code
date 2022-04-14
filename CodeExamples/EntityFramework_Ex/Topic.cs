using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex 
{ 
    public class Topic
    {
        public int Id { get; set; }
        public string Detail { get; set; }

        // A Topic can exist under one Course , So that  take a course instance here

        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}

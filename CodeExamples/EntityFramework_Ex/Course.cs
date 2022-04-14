using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Ex
{
    public class Course
    {
        // thats are conventional relationship 
        public int Id { get; set; } 
        public string Title { get; set; }
        public double Fee { get; set; }
        public DateTime ClassStartDate { get; set; }

        // A Course can have many topic, so here to take a list of topic
        public List<Topic> Topics { get; set; }


        // For creating ManyToMany relations with Sudents and Courses Model/table/Entity 

        public List<CourseStudents> Students { get; set; } 



    }
}

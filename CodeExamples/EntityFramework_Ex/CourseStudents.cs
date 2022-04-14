using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//it's Pivot entity / model / class , uses for creating manyTomany Relation with Students and Courses Model/ Entity .

namespace EntityFramework_Ex
{
    public class CourseStudents
    {
        public int CourseId { get; set; }
        public int StudentId { get; set;}

        public DateTime EnrollDate { get; set; }

        public Course Course { get; set; }
        
        public Student Student { get; set; }



    }
}

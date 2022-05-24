using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Course
    {
        public string Title { get; set; }
        public int Fees { get; set; }
        public int CategoryId { get; set; }

    }



    // for initializing Course , create a static class Courses  here :

    public static class Courses
    {
        public static List<Course> CourseList = new List<Course>
        {
            new Course { Title = "C#", Fees = 15000, CategoryId = 1 },
            new Course { Title = "Java", Fees = 12000,CategoryId = 1 },
            new Course { Title = "Python", Fees = 8000,CategoryId = 1 },
            new Course { Title = "MS Excel", Fees = 1200,CategoryId = 2 },
            new Course { Title = "Adobe PhotoShop", Fees = 5000,CategoryId = 2 },
            new Course { Title = "Networking & Security ", Fees = 12000,CategoryId = 3 },
            new Course { Title = "telecom", Fees = 8000,CategoryId = 3 },
        };
    }

}

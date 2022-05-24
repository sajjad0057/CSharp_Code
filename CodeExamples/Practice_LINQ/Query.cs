using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Query
    {
        public List<Category> GetCategory() => Categories.CategoryList;
        public List<Course> GetCourse() => Courses.CourseList;

        public Query()
        {
            List<Course> Courselist = GetCourse();
            List<Category> CategoryList = GetCategory();

            var course = (from c in Courselist
                          where c.Fees > 10000
                          join cat in CategoryList on c.CategoryId equals cat.Id                             
                          select (c,category:cat.Name));

           

            foreach(var cos in course)
            {
                Console.WriteLine($"Course Name : {cos.c.Title} ; Course Fees : {cos.c.Fees} ; Category Name : {cos.category}");
            }
                             

        }
    }
}

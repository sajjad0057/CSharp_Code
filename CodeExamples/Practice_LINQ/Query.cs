using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Query
    {
        public List<Course> GetCategory() => Category.CourseList;
        public List<Category> GetCategories() => Course.categoryList;

        public Query()
        {
            List<Course> Courselist = GetCategory();
            List<Category> categories = GetCategories();

            var course = (from c in Courselist
                          where c.Fees > 10000
                          join cat in categories on c.CategoryId equals cat.Id                             
                          select (c,cate:cat.Name));

           

            foreach(var cos in course)
            {
                Console.WriteLine($"Course Name : {cos.c.Title} ; Course Fees : {cos.c.Fees} ; Category Name : {cos.cate}");
            }
                             

        }
    }
}

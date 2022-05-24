using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }         
       
    }


    // for initializing Category , create a static class Categories  here :


    public static class Categories
    {
        public static List<Category> CategoryList = new List<Category>
        {
            new Category { Id = 1, Name = "Programming Language"},
            new Category { Id = 2, Name = "Software"},
            new Category{ Id = 3, Name = "Data Communications"},
        };
    }
}

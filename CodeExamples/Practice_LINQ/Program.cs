using Practice_LINQ;
using System.Text.Json;
using Task3;

List<Course> courses = new List<Course>();
courses.Add(new Course { CategoryId = 1, Fees = 3888, Title = "C#" });
courses.Add(new Course { CategoryId = 2, Fees = 7000, Title = "Laravel" });
courses.Add(new Course { CategoryId = 3, Fees = 9000, Title = "Asp.net" });

List<Category> categories = new List<Category>();
categories.Add(new Category { Id = 1, Name = "Beginner" });
categories.Add(new Category { Id = 2, Name = "Intermediate" });
categories.Add(new Category { Id = 3, Name = "Advanced" });

List<(string CourseName, int Fees, string CategoryName)> result = (from course in courses
                                                                   join category in categories on course.CategoryId equals category.Id
                                                                   select (course.Title, course.Fees, category.Name)).ToList();

foreach (var resultItem in result)
    Console.WriteLine($"{resultItem.CourseName}, {resultItem.Fees}, {resultItem.CategoryName}");


IList<string> listOfString = new List<string>()
{
    "asdsaatertereraaagddfdfsdgfsaasddsafsdhfhdsjgvndfjksdfnsdm",
    "sfnsdjfsdnrrrrrrrrrrrrrr",
    "sfsdkfjkdsnkiiiiiiiiiiiiiiiiii",
    "sjaaaaaaaaadffhiajfewjfkxxxxxxxxxxx"
};


IList<string> filteredString = new List<string>()
{
    "iiiii",
    "aaaaaa"
};


var result11 = listOfString.Where(e => filteredString.Any(f=>e.Contains(f))).ToList();

Console.WriteLine(JsonSerializer.Serialize(result11));

PracticeGroupBy practiceGroupBy = new PracticeGroupBy();
practiceGroupBy.TestClass();

Console.WriteLine();


















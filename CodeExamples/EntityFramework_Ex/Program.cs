using EntityFramework_Ex;
using Microsoft.EntityFrameworkCore;

TestDbContext context = new TestDbContext();

#region Insert Data in DB

// insert data in table Student 
//Student student1 = new Student { Name = "sajjad", Cgpa = 3.2, Address = "Rangpur", DateOfBirth = new DateTime(1991,03,06) };

// way 1  

//context.Students.Add(student1);

// way 2

//context.Students.Add(new Student { Name = "sakib", Cgpa = 3.05, DateOfBirth = new DateTime(2002,05,09), Address = "Dhaka" });

//context.Students.Add(new Student { Name = "sajjad", Cgpa = 3.20, DateOfBirth = new DateTime(2002,05,09), Address = "Rangpur" });

//context.Students.Add(new Student { Name = "zahan", Cgpa = 3.55, DateOfBirth = new DateTime(1998,05,09), Address = "pabna" });

//context.SaveChanges();

#endregion 



#region Retrive and Update Data 

//Retriving and update Data from Database :

//Student student2 = context.Students.Where(x => x.Name == "sakib").FirstOrDefault();  //FirstOrDefault() methods retrive first data  of satisfying condition or criteria 

//student2.Cgpa = 3.90;

//context.SaveChanges();

#endregion


#region Delete or Remove Data 

// delete or remove data from data table 

//if(student1 != null)
//{
//    context.Students.Remove(student1);
//    context.SaveChanges();
//}

#endregion 


#region  Retriving Data as a List 

// Get all data as a list :

Console.WriteLine("List of Students : ");

//List<Student > studentList = context.Students.ToList();

// Apply filtering : 

List<Student> studentList = context.Students.Where(x => x.Cgpa > 3.5).ToList();


foreach (Student student in studentList)
{
    Console.WriteLine($"Name : {student.Name} ; Cgpa : {student.Cgpa} ; Address : {student.Address} ; DateOfBirth : {student.DateOfBirth}");
}

#endregion

#region Insert Data in Course Table 

//Course course1 = new Course
//{
//    Title = "C#",
//    Fee = 8000,
//    ClassStartDate = new DateTime(2022,02,14),
//    Topics = new List<Topic>
//    {
//        new Topic{Detail = "Getting started"},
//        new Topic{Detail = "Advanced Topic"}
//           //here CourseId set automatically cz, Topics list  child of Course . so detect Course Id and select automatic .
//    }
//};

//context.Courses.Add(course1);

////another way to set data 

//context.Courses.Add(new Course
//{
//    Title = "Java",
//    Fee = 10000,
//    ClassStartDate = new DateTime(2021,4,3),
//    Topics = new List<Topic>
//        {
//        new Topic{Detail = "Getting Started Java"},
//        new Topic{Detail = "Advanced Java"},
//        }
//});

//context.Courses.Add(new Course
//{
//    Title = "Python",
//    Fee = 10000,
//    ClassStartDate = new DateTime(2021,4,3),
//    Topics = new List<Topic>
//        {
//        new Topic{Detail = "Getting Started Python"},
//        new Topic{Detail = "Python For MachineLearning"},
//        }
//});


//context.SaveChanges();


#endregion


#region Retrive data from Course table 

Console.WriteLine("Courses Data : ");

List<Course> courseList = context.Courses.Include(x => x.Topics).ToList();  // Include() access child data of (Here Courses) table 

foreach (Course course in courseList)
{
    Console.WriteLine($"Course Name : {course.Title} ; Course Fee : {course.Fee} ; Class Start : {course.ClassStartDate}");
    Console.WriteLine("Course Topics : ");
    foreach (Topic topic in course?.Topics)
    {
        Console.WriteLine($"{topic.Detail}");
    }
};

#endregion

#region Create ManyToMany RelationShip and insert data 

Course existingCourse = context.Courses.Where(x => x.Id == 1)
    .Include(y => y.Topics)
    .FirstOrDefault();

Console.WriteLine(existingCourse.Title);

Student existingStudent1 = context.Students.Where(x => x.Id == 3).FirstOrDefault();


existingCourse.Students = new List<CourseStudents>
{
   // new CourseStudents{ Student = existingStudent1,EnrollDate = new DateTime(2022,1,1) },  // here set existing student of Student Table 

    // Set new Student in CourseStudents Pivot table/model/entity

    new CourseStudents{ Student = new Student
    { Name = "Nafiul Fatta",
      Cgpa = 3.94,
      Address = "Gazipur" ,
      DateOfBirth = new DateTime(1997,04,06),
      
    },

    EnrollDate = new DateTime(2022,3,1),
  }

};

context.SaveChanges();



#endregion








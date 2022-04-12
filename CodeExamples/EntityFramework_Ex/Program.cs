
// insert data in table Student 

using EntityFramework_Ex;

Student student1 = new Student { Name = "sajjad", Cgpa = 3.2, Address = "Rangpur" , DateOfBirth = new DateTime(1991,03,06) };   

TestDbContext context = new TestDbContext();

// way 1  

//context.Students.Add(student1);

// way 2


//context.Students.Add(new Student { Name = "sakib", Cgpa = 4.00, DateOfBirth = new DateTime(2002, 05, 09), Address = "Dhaka" });

//context.SaveChanges();


//Retrinving and update Data from Database :

student1 = context.Students.Where(x => x.Name == "sajjad").FirstOrDefault();

student1.Cgpa = 3.90;

context.SaveChanges();


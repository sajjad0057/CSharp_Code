
// insert data in table Student 

using EntityFramework_Ex;

Student student1 = new Student { Name = "sajjad", Cgpa = 3.2, Address = "Rangpur" , DateOfBirth = new DateTime(1991,03,06) };   

TestDbContext context = new TestDbContext();

// way 1  

//context.Students.Add(student1);

// way 2


//context.Students.Add(new Student { Name = "sakib", Cgpa = 3.05, DateOfBirth = new DateTime(2002, 05, 09), Address = "Dhaka" });

//context.Students.Add(new Student { Name = "sajjad", Cgpa = 3.20, DateOfBirth = new DateTime(2002, 05, 09), Address = "Rangpur" });

context.Students.Add(new Student { Name = "zahan", Cgpa = 3.55, DateOfBirth = new DateTime(1998, 05, 09), Address = "pabna" });

context.SaveChanges();




//Retriving and update Data from Database :

Student student2 = context.Students.Where(x => x.Name == "sakib").FirstOrDefault();  //FirstOrDefault() methods retrive first data  of satisfying condition or criteria 

student2.Cgpa = 3.90;

context.SaveChanges();

// delete or remove data from data table 

//if(student1 != null)
//{
//    context.Students.Remove(student1);
//    context.SaveChanges();
//}



// Get all data as a list :

Console.WriteLine("List of Students : ");

//List<Student > studentList = context.Students.ToList();

// Apply filtering : 

List<Student> studentList = context.Students.Where(x => x.Cgpa > 3.5).ToList();


foreach (Student student in studentList)
{
    Console.WriteLine($"Name : {student.Name} ; Cgpa : {student.Cgpa} ; Address : {student.Address} ; DateOfBirth : {student.DateOfBirth}");
}






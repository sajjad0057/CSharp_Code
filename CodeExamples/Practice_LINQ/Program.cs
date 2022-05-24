using Task3;


Course course1 = new Course();
Course course2 = new Course();
Course course3 = new Course();
Course course4 = new Course();
Course course5 = new Course();
Course course6 = new Course();

Category category1 = new Category();
Category category2 = new Category();


category1.Id = 1;
category2.Id = 2;


category1.Name = "Programming Language";
category2.Name = "Software";



course1.Title = "Python";
course2.Title = "Java";
course3.Title = "C#";
course4.Title = "Adobe Photoshop";
course5.Title = "Go";
course6.Title = "MS Exell";



course1.Fees = 6000;
course2.Fees = 11000;
course3.Fees = 13000;
course4.Fees = 5000;
course5.Fees = 7000;
course6.Fees = 11000;


course1.CategoryId = category1.Id;
course2.CategoryId = category1.Id;
course3.CategoryId = category1.Id;
course4.CategoryId = category2.Id;
course5.CategoryId = category1.Id;
course6.CategoryId = category2.Id;


Category.CourseList.Add(course1);
Category.CourseList.Add(course2);
Category.CourseList.Add(course3);
Category.CourseList.Add(course5);
Category.CourseList.Add(course4);
Category.CourseList.Add(course6);

Course.categoryList.Add(category1);
Course.categoryList.Add(category2);


Query q = new Query();

















using ADO.NET_Example;


string connectionString = "Server = DESKTOP-SU7UN5F\\SQLEXPRESS ; Database=CSharpPractice1 ; User Id = CSharpPractice1 ;Password = 123456;";
DataUtility dataUtility = new DataUtility(connectionString);


//var sql = "insert into Students([Name],Cgpa,DateOfBirth) values('sakib',3.58,'2002-07-11')";
//var sql = "update Students set Cgpa = 3.94 where id = 4";
//var sql = "delete from Students where id = 4";
//dataUtility.ExecuteCommand(sql);

//var query = "Select Name,DateOfBirth from Students";

var query = "Select * from Students";

dataUtility.ExecuteQuery(query);





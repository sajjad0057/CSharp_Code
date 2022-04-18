using Prectice_ADO.NET;

string connectionString = "Server = DESKTOP-SU7UN5F\\SQLEXPRESS ; Database= PracticeForExam2 ; User Id = CSharpPractice1 ;Password = 123456;";
DataManageable dataManage = new DataManageable(connectionString);


#region Execute command  for Create,Update or Delete Data 

//string sql = "insert into Students([Name],Cgpa,Dob) values('nafiul',3.5,'1998-2-2')";
//string sql = "update Students set Name = 'sakib' where Cgpa = 3.50";

//string sql = "delete from Students where id = 3";

//dataManage.ExecuteCommand(sql);


#endregion



#region Execute Query for Retriving Data

string query = "Select * from Students";

List<Dictionary<string, object>> values = dataManage.ExecuteQuery(query);

foreach (Dictionary<string, object> value in values)
{
    foreach (string key in value.Keys)
    {
        Console.Write($" {key} : {value[key]}   ");
    }
    Console.WriteLine();
}

#endregion
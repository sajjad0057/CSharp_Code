using Practice_ADO.NET;


string connectionString = "Server = DESKTOP-SU7UN5F\\SQLEXPRESS ; Database= Exam_2 ; User Id = CSharpPractice1 ;Password = 123456;";

DataManagement dataManage = new DataManagement(connectionString);

Console.WriteLine("Insert Products data : ");

Console.Write("Title : ");

string title = Console.ReadLine();

Console.Write("Price : ");

decimal price = Decimal.Parse(Console.ReadLine());

Console.Write("IsAvailable Or Not :");

bool isAvailable = bool.Parse(Console.ReadLine());

DateTime createdOn = DateTime.Now;

Console.Write("Available Quantity :");

int availableQuantity = int.Parse(Console.ReadLine());

string sql = $"insert into Products ([Title],Price,IsAvailable,CreatedOn,AvailableQuantity) values ('{title}',{price},'{isAvailable}','{createdOn}',{availableQuantity})";

// //string sql = $"insert into Products ([Title],Price,IsAvailable,CreatedOn,AvailableQuantity) values('pen2',50,1,'2022-02-02',34)";

dataManage.ExecuteCommand(sql);

Console.WriteLine("All Products Data : ");


string query = "Select * from Products";

List<Dictionary<string, object>> values = dataManage.ExecuteQuery(query);

foreach (Dictionary<string, object> value in values)
{
    foreach (string key in value.Keys)
    {
        Console.Write($" {key} : {value[key]}   ");
    }
    Console.WriteLine();
}